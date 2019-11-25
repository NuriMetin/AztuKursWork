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

namespace StudentRatingTableApp.v1._0.Forms.ReytingForms.GroupsRating
{
    public partial class GroupsRatingForUniversity : Form
    {
        public GroupsRatingForUniversity()
        {
            InitializeComponent();
        }

        private void GroupsRatingForUniversity_Load(object sender, EventArgs e)
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
            }
        }

        private void cmbx_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sesValue = cmbx_session.SelectedValue.ToString();
            List<GroupsAVGModel> groupsAVGModels = new List<GroupsAVGModel>();

            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = @" SELECT  GR.Name AS GrName , AVG(Pounts.ResultPount) AS SessiounAVGPounts
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
                        WHERE SES.ID=" + sesValue + " Group by GR.Name  ORDER BY SessiounAVGPounts DESC";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                GroupsAVGModel groupsAVGModel = new GroupsAVGModel()
                                {
                                    GroupName = sqlDataReader["GrName"].ToString(),
                                    GroupResult = int.Parse(sqlDataReader["SessiounAVGPounts"].ToString())
                                };
                                groupsAVGModels.Add(groupsAVGModel);
                            }
                            dtgv_student_rating.DataSource = groupsAVGModels;
                        }
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

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }
    }
}
