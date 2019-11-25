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
using StudentRatingTableApp.v1._0.Models.ModelsSet;
using StudentRatingTableApp.v1._0.Core;

namespace StudentRatingTableApp.v1._0.Forms.ReytingForms
{
    public partial class StudentRatingForm : Form
    {
        public StudentRatingForm()
        {
            InitializeComponent();
        }

        private void StudentRatingForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Extension.ConnectToDb()))
            {
                sqlConnection.Open();

                //--------------- Session combobox on load--------------------------

                string sesQuery = "SELECT ID ,Name FROM Sessions";
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
                List<Faculty> faculties = new List<Faculty>();

                using (SqlConnection facConnection = new SqlConnection(Extension.ConnectToDb()))
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

            string query = @"SELECT PR.ID AS PrID, PR.Name AS PrName FROM Professions AS PR
                        INNER JOIN Departments AS DP
                        ON PR.DepartmentID = DP.ID
                        INNER JOIN Faculties AS F
                        ON F.ID = DP.FacultyID
                        WHERE F.ID = " + facValue;

            using (SqlConnection sqlConnection = new SqlConnection(Extension.ConnectToDb()))
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
            string PrValue = cmbx_profession.SelectedValue.ToString();
            List<Group> groups = new List<Group>();
            using (SqlConnection connection = new SqlConnection(Extension.ConnectToDb()))
            {
                connection.Open();


                string query = @"SELECT GR.ID AS [GroupID], GR.Name AS [GroupName], GR.ProfessionID AS [GroupProfessionName] FROM Professions AS PR
                            INNER JOIN Groups AS GR ON GR.ProfessionID = PR.ID WHERE GR.ProfessionID = " + PrValue;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {

                            while (sqlDataReader.Read())
                            {

                                Group group = new Group()
                                {
                                    ID = int.Parse(sqlDataReader["GroupID"].ToString()),
                                    Name = sqlDataReader["GroupName"].ToString(),
                                };
                                groups.Add(group);

                            }
                        }
                    }
                }
            }
            List<Comboitem> comboitems = new List<Comboitem>();
            for (int i = 0; i < groups.Count; i++)
            {
                Comboitem comboitem = new Comboitem();
                comboitem.Id = groups[i].ID;
                comboitem.Name = groups[i].Name;
                comboitems.Add(comboitem);
            }

            cmbx_group.ValueMember = "ID";
            cmbx_group.DisplayMember = "Name";
            cmbx_group.DataSource = comboitems;

        }

        private void cmbx_group_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sesValue = cmbx_session.SelectedValue.ToString();
            string grValue = cmbx_group.SelectedValue.ToString();
            List<FinishResult> finishResults = new List<FinishResult>();
            using (SqlConnection sqlConnection = new SqlConnection(Extension.ConnectToDb()))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(Extension.StudentRatingQuery(sesValue, grValue), sqlConnection))
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }
    }
}

