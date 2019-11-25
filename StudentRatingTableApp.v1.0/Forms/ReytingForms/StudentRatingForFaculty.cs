using StudentRatingTableApp.v1._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRatingTableApp.v1._0.Forms.ReytingForms
{
    public partial class StudentRatingForFaculty : Form
    {
        public StudentRatingForFaculty()
        {
            InitializeComponent();
        }

        private void StudentRatingForFaculty_Load(object sender, EventArgs e)
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
                string facConnect = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }

        private void Cmbx_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sesValue = cmbx_session.SelectedValue.ToString();
            string facValue = cmbx_faculty.SelectedValue.ToString();

            List<FinishResult> allFinishResults = new List<FinishResult>();
            string conString = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS;Initial Catalog=AZTU;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();

                string query = @"SELECT  Stud.Name AS [StName] , AVG(Pounts.ResultPount) AS SessiounAVGPounts
                    FROM Students as Stud
                    INNER JOIN Groups AS GR
                    ON GR.ID=Stud.GroupID
                    INNER JOIN Pounts
                    ON Pounts.StudentID = Stud.ID
                    INNER JOIN Sessions
                    ON SessionID = Pounts.SessionID
                    INNER JOIN Subjects
                    ON Pounts.SubjectID = Subjects.ID
                    WHERE  SessionID=" + sesValue + " AND GR.ID=" + facValue + " Group by Stud.Name ORDER BY SessiounAVGPounts DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                FinishResult allFinishResult = new FinishResult()
                                {
                                    SudentName = sqlDataReader["StName"].ToString(),
                                    Results = int.Parse(sqlDataReader["SessiounAVGPounts"].ToString())
                                };
                                allFinishResults.Add(allFinishResult);
                            }
                            dtgv_student_rating.DataSource = allFinishResults;


                        }

                    }
                }


            }
        }
    }
}
