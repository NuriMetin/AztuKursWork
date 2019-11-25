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

namespace StudentRatingTableApp.v1._0.Forms.AddingForms
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
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
        private void cmbx_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string facValue = cmbx_faculty.SelectedValue.ToString();
            List<ProfessionModel> professionModels = new List<ProfessionModel>();

            List<FinishResult> allFinishResults = new List<FinishResult>();

            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
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

                //--------------------------------------

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
            string conString = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
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

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string grValue = cmbx_group.SelectedValue.ToString();

                string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
                using (SqlConnection sqlConnection = new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string query = @"INSERT INTO Students(Name, Surname,Payment,GroupID) VALUES(@p1,@p2,@p3,@p4)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@p1", txbx_name.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", txbx_surname.Text);
                        sqlCommand.Parameters.AddWithValue("@p3", txbx_payment.Text);
                        sqlCommand.Parameters.AddWithValue("@p4", grValue.ToString());

                        sqlCommand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Əməliyyat müvəffəqiyyətlə yerinə yetirildi");
                txbx_name.Text = "";
                txbx_surname.Text = "";
                txbx_payment.Text = "";
            }
            catch
            {
                MessageBox.Show("Əməliyyat yerinə yetirilmədi");
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
