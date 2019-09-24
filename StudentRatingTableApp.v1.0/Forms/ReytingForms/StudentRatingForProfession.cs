using StudentRatingTableApp.v1._0.Models;
using StudentRatingTableApp.v1._0.Models.ModelsSet;
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
    public partial class StudentRatingForProfession : Form
    {
        public StudentRatingForProfession()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }

        private void StudentRatingForProfession_Load(object sender, EventArgs e)
        {
            string connection = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";

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
                string facConnect = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";
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
            string sesValue = cmbx_session.SelectedValue.ToString();
            string facValue = cmbx_faculty.SelectedValue.ToString();
            List<ProfessionModel> professionModels = new List<ProfessionModel>();

            List<FinishResult> allFinishResults = new List<FinishResult>();

            string connection = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";
            string query = @"SELECT PR.ID AS PrID, PR.Name AS PrName FROM Professions AS PR
                        INNER JOIN Departments AS DP
                        ON PR.DepartmentID = DP.ID
                        INNER JOIN Faculties AS F
                        ON F.ID = DP.FacultyID
                        WHERE F.ID = " + facValue;
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                ProfessionModel professionModel = new ProfessionModel()
                                {
                                    ID = int.Parse(sqlDataReader["PrID"].ToString()),
                                    Name = sqlDataReader["PrName"].ToString()
                                };
                                professionModels.Add(professionModel);
                            }
                        }
                    }
                }
            }
            List<Comboitem> comboitems = new List<Comboitem>();

            for (int i = 0; i < professionModels.Count; i++)
            {
                Comboitem comboitem = new Comboitem()
                {
                    Id = professionModels[i].ID,
                    Name = professionModels[i].Name

                };
                comboitems.Add(comboitem);

            }
            cmbx_profession.ValueMember = "ID";
            cmbx_profession.DisplayMember = "Name";
            cmbx_profession.DataSource = comboitems;
        }

        private void cmbx_faculty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sesValue = cmbx_session.SelectedValue.ToString();
            string facValue = cmbx_faculty.SelectedValue.ToString();
            List<ProfessionModel> professionModels = new List<ProfessionModel>();

            List<FinishResult> allFinishResults = new List<FinishResult>();

            string connection = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";
            string query = @"SELECT PR.ID AS PrID, PR.Name AS PrName FROM Professions AS PR
                        INNER JOIN Departments AS DP
                        ON PR.DepartmentID = DP.ID
                        INNER JOIN Faculties AS F
                        ON F.ID = DP.FacultyID
                        WHERE F.ID = " + facValue;
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                ProfessionModel professionModel = new ProfessionModel()
                                {
                                    ID = int.Parse(sqlDataReader["PrID"].ToString()),
                                    Name = sqlDataReader["PrName"].ToString()
                                };
                                professionModels.Add(professionModel);
                            }
                        }
                    }
                }
            }
            List<Comboitem> comboitems = new List<Comboitem>();

            for (int i = 0; i < professionModels.Count; i++)
            {
                Comboitem comboitem = new Comboitem()
                {
                    Id = professionModels[i].ID,
                    Name = professionModels[i].Name

                };
                comboitems.Add(comboitem);

            }
            cmbx_profession.ValueMember = "ID";
            cmbx_profession.DisplayMember = "Name";
            cmbx_profession.DataSource = comboitems;
        }

        private void cmbx_profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sesValue = cmbx_session.SelectedValue.ToString();
            string prValue = cmbx_profession.SelectedValue.ToString();
            string connection = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";
            List<FinishResult> finishResults = new List<FinishResult>();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = @" SELECT Stud.Name AS[StName], AVG(Pounts.ResultPount) AS SessiounAVGPounts
                            FROM Students as Stud
                            INNER JOIN Groups AS GR
                            ON GR.ID = Stud.GroupID
                            INNER JOIN Professions AS PR
                            ON PR.ID = GR.ProfessionID
                            INNER JOIN Pounts
                            ON Pounts.StudentID = Stud.ID
                            INNER JOIN Sessions
                            ON SessionID = Pounts.SessionID
                            INNER JOIN Subjects
                            ON Pounts.SubjectID = Subjects.ID
                            WHERE SessionID=" + sesValue + " AND PR.ID="+prValue+" Group by Stud.Name ORDER BY SessiounAVGPounts DESC";
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                FinishResult finishResult = new FinishResult()
                                {
                                    SudentName = sqlDataReader["StName"].ToString(),
                                    Results = int.Parse(sqlDataReader["SessiounAVGPounts"].ToString())
                                };
                                finishResults.Add(finishResult);
                            }
                            dtgv_student_rating.DataSource = finishResults;
                        }
                    }
                }
            }

        }
    }
}
