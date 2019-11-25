using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StudentRatingTableApp.v1._0.Models;

namespace StudentRatingTableApp.v1._0.Forms.ReytingForms
{
    public partial class GroupsForFaculty : Form
    {
        public GroupsForFaculty()
        {
            InitializeComponent();
        }
        private void GroupsForFaculty_Load(object sender, EventArgs e)
        {
            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();

                //--------------- Session combobox on load--------------------------

                string sesQuery = " SELECT ID ,Name FROM Sessions";
                using (SqlCommand sesCommand = new SqlCommand(sesQuery, sqlConnection))
                {
                    SqlDataReader sesReader = sesCommand.ExecuteReader();
                    DataTable sesTable = new DataTable();

                    sesTable.Columns.Add("ID", typeof(string));
                    sesTable.Columns.Add("Name", typeof(string));

                    sesTable.Load(sesReader);

                    cmbx_session.ValueMember = "ID";
                    cmbx_session.DisplayMember = "Name";
                    cmbx_session.DataSource = sesTable;
                }

                //----------------- Faculty combobox on load ----------------------------
                string facConnect = "Data Source=DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
                List<Faculty> faculties = new List<Faculty>();

                using (SqlConnection facConnection = new SqlConnection(facConnect))
                {
                    facConnection.Open();
                    string facQuery = "SELECT F.ID AS FacID, F.Name AS FacName FROM Faculties AS F";
                    using (SqlCommand facCommand = new SqlCommand(facQuery, facConnection))
                    {
                        using (SqlDataReader sqlDataReader = facCommand.ExecuteReader())
                        {
                            using (DataTable dataTable = new DataTable())
                            {
                                while (sqlDataReader.Read())
                                {
                                    Faculty faculty = new Faculty()
                                    {
                                        ID = int.Parse(sqlDataReader["FacID"].ToString()),
                                        Name = sqlDataReader["FacName"].ToString()
                                    };
                                    faculties.Add(faculty);
                                }
                            }
                        }
                    }
                }

                List<FacCombo> facCombos = new List<FacCombo>();
                for (int i = 0; i < faculties.Count; i++)
                {
                    FacCombo facCombo = new FacCombo()
                    {
                        ID = faculties[i].ID,
                        Name = faculties[i].Name

                    };
                    facCombos.Add(facCombo);

                }
                cmbx_faculty.ValueMember = "ID";
                cmbx_faculty.DisplayMember = "Name";
                cmbx_faculty.DataSource = facCombos;
            }
        }
        private void cmbx_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string facValue = cmbx_faculty.SelectedValue.ToString();
            string sesValue = cmbx_session.SelectedValue.ToString();

            List<FinishResult> finishResults = new List<FinishResult>();

            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            using(SqlConnection sqlConnection=new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = @"SELECT  Stud.Name AS [StName] , AVG(Pounts.ResultPount) AS SessiounAVGPounts
                        FROM Students as Stud
                        INNER JOIN Groups AS GR
                        ON GR.ID=Stud.GroupID
                        INNER JOIN Professions AS PR
                        ON PR.ID=GR.ProfessionID
                        INNER JOIN Departments AS DP
                        ON DP.ID = PR.DepartmentID
                        INNER JOIN Faculties AS F
                        ON F.ID=DP.FacultyID
                        INNER JOIN Pounts
                        ON Pounts.StudentID = Stud.ID
                        INNER JOIN Sessions AS SES
                        ON SES.ID = Pounts.SessionID
                        INNER JOIN Subjects
                        ON Pounts.SubjectID = Subjects.ID
                        WHERE F.ID="+facValue+" AND SES.ID="+sesValue+" Group by Stud.Name  ORDER BY SessiounAVGPounts DESC";
                using (SqlCommand sqlCommand=new SqlCommand(query, sqlConnection))
                {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            FinishResult finishResult = new FinishResult()
                            {
                                SudentName = sqlDataReader["StName"].ToString(),
                                Results=int.Parse(sqlDataReader["SessiounAVGPounts"].ToString())
                            };
                            finishResults.Add(finishResult);
                        }
                        dtgv_groups.DataSource = finishResults;
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }

        private void btn_show_result_Click(object sender, EventArgs e)
        {
            //string facValue = cmbx_faculty.SelectedValue.ToString();
            //string sesValue = cmbx_session.SelectedValue.ToString();

            //string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            //using(SqlConnection sqlConnection=new SqlConnection)
            //{
            //    string query = "";
            //    sqlConnection.Open();
            //    using(SqlCommand sqlCommand=new SqlCommand(query, sqlConnection))
            //    {
            //        using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
            //        {
            //            using (DataTable dataTable= new DataTable())
            //            {
            //                while (sqlDataReader.Read())
            //                {
                                    
            //                }
            //            }
            //        }
            //    }
            //}
        }

        private void Cmbx_session_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
