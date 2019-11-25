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
    public partial class AddGroup : Form
    {
        public AddGroup()
        {
            InitializeComponent();
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {
            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
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

            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            List<DepartmentModel> departmentModels = new List<DepartmentModel>();
            using(SqlConnection sqlConnection=new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = @"SELECT ID, Name FROM Departments WHERE FacultyID="+facValue;
                using(SqlCommand sqlCommand=new SqlCommand(query, sqlConnection))
                {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using(DataTable dataTable=new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                DepartmentModel departmentModel = new DepartmentModel()
                                {
                                    DepartmentID = int.Parse(sqlDataReader["ID"].ToString()),
                                    DepartmentName = sqlDataReader["Name"].ToString()
                                };
                                departmentModels.Add(departmentModel);
                            }
                        }
                    }
                }
            }
            List<FacDpCombo> facDpCombos = new List<FacDpCombo>();
            for(int i=0; i<departmentModels.Count; i++)
            {
                FacDpCombo facDpCombo = new FacDpCombo()
                {
                    ID= departmentModels[i].DepartmentID,
                    Name= departmentModels[i].DepartmentName
                };
                facDpCombos.Add(facDpCombo);
            }
            cmbx_department.ValueMember = "ID";
            cmbx_department.DisplayMember = "Name";
            cmbx_department.DataSource = facDpCombos;
        }

        private void cmbx_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string dpValue = cmbx_department.SelectedValue.ToString();

            string connection = "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS; Initial Catalog=AZTU; Integrated Security=true;";
            List<ProfessionModel> professionModels = new List<ProfessionModel>();
            using(SqlConnection sqlConnection=new SqlConnection(connection))
            {
                sqlConnection.Open();
                string query = @"SELECT ID, Name FROM Professions WHERE DepartmentID =" + dpValue;
                using(SqlCommand sqlCommand=new SqlCommand(query, sqlConnection))
                {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        using(DataTable dataTable=new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {
                                ProfessionModel professionModel = new ProfessionModel()
                                {
                                    ID = int.Parse(sqlDataReader["ID"].ToString()),
                                    Name = sqlDataReader["Name"].ToString()
                                };
                                professionModels.Add(professionModel);
                            }
                        }
                    }
                }
            }
            List<DpPrfCombo> dpPrfCombos = new List<DpPrfCombo>();
            for(int i=0; i < professionModels.Count; i++)
            {
                DpPrfCombo dpPrfCombo = new DpPrfCombo()
                {
                    ID=professionModels[i].ID,
                    Name=professionModels[i].Name
                };
                dpPrfCombos.Add(dpPrfCombo);
            }
            cmbx_profession.ValueMember = "ID";
            cmbx_profession.DisplayMember = "Name";
            cmbx_profession.DataSource = dpPrfCombos;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string prValue = cmbx_profession.SelectedValue.ToString();
                
                string connection= "Data Source= DESKTOP-A4JVK6F\\SQLEXPRESS;; Initial Catalog=AZTU; Integrated Security=true;";
                using(SqlConnection sqlConnection=new SqlConnection(connection))
                {
                    sqlConnection.Open();

                    string query = @"INSERT INTO Groups(Name, ProfessionID) VALUES(@p1,@p2)";

                    using(SqlCommand sqlCommand=new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@p1", txbx_group_name.Text);
                        sqlCommand.Parameters.AddWithValue("@p2", prValue.ToString());

                        sqlCommand.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Əməliyyat müvəffəqiyyətlə yerinə yetirildi");
                txbx_group_name.Text = "";
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
