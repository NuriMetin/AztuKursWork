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
using StudentRatingTableApp.v1._0.Forms.AddingForms;
using StudentRatingTableApp.v1._0.Models;
using StudentRatingTableApp.v1._0.Models.ModelsSet;

namespace StudentRatingTableApp.v1._0.Forms.AddingForms
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void AddPountForm_Load(object sender, EventArgs e)
        {
            
            
            
            
            
            #region profession combo fil on form load  
            //string conString = "Data Source=DESKTOP-6D6VFHT\\TSQL;Initial Catalog=AZTU;Integrated Security=SSPI";
            //string PrfQuery = "Select ID,Name From Professions";

            //SqlConnection sqlConnection = new SqlConnection(conString);
            //sqlConnection.Open();
            //SqlCommand prfCommand = new SqlCommand(PrfQuery, sqlConnection);

            //SqlDataReader PrfReader = prfCommand.ExecuteReader();

            //DataTable PrfDtable = new DataTable();

            //PrfDtable.Columns.Add("ID", typeof(string));
            //PrfDtable.Columns.Add("Name", typeof(string));

            //PrfDtable.Load(PrfReader);

            //cmbx_profession.ValueMember = "ID";
            //cmbx_profession.DisplayMember = "Name";
            //cmbx_profession.DataSource = PrfDtable;
            //grbx_subjects.Hide();
            #endregion

            string facConnect = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";
            List<Faculty> faculties = new List<Faculty>();

            using (SqlConnection facConnection = new SqlConnection(facConnect))
            {
                facConnection.Open();
                string facQuery = "SELECT F.ID AS FacID, F.Name AS FacName FROM Faculties AS F";
                using (SqlCommand facCommand = new SqlCommand(facQuery, facConnection))
                {
                    //SqlDataReader facReader = facCommand.ExecuteReader();
                    //DataTable facTable = new DataTable();

                    //facTable.Columns.Add("ID", typeof(string));
                    //facTable.Columns.Add("Name", typeof(string));

                    //facTable.Load(facReader);
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

        private void cmbx_profession_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            string PrValue = cmbx_profession.SelectedValue.ToString();
            List<Group> groups = new List<Group>();
            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";
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

                                //cmbx_group.DataSource = null;
                                //cmbx_group.Items.Clear();

                                Group group = new Group()
                                {
                                    ID = int.Parse(sqlDataReader["GroupID"].ToString()),
                                    Name = sqlDataReader["GroupName"].ToString(),
                                    //ProfessionID = int.Parse(sqlDataReader["GroupProfessionName"].ToString())
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

            cmbx_group.DataSource = comboitems;
            cmbx_group.DisplayMember = "Name";

            grbx_subjects.Hide();
        }

        private void cmbx_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            string GrValue = cmbx_group.SelectedValue.ToString();

            List<Student> students = new List<Student>();
            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();


                string query = @"SELECT ST.ID AS StID,  ST.Name AS StName, ST.Surname AS StSurname, ST.Payment AS [Student Payment form], St.GroupID AS StGroupId FROM Groups AS GR
                            INNER JOIN Students AS ST
                            ON ST.GroupID = GR.ID
                            WHERE ST.GroupID=" + GrValue;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            while (sqlDataReader.Read())
                            {

                                Student student = new Student()
                                {
                                    Id = int.Parse(sqlDataReader["StID"].ToString()),
                                    Surname = sqlDataReader["StSurname"].ToString(),
                                    Name = sqlDataReader["StName"].ToString(),
                                    PaymentForm = sqlDataReader["Student Payment form"].ToString(),
                                    //GroupID = int.Parse(sqlDataReader["StGroupID"].ToString())
                                };
                                students.Add(student);

                            }


                            lsbx_students.DataSource = students;
                         
                        }

                    }
                }
            }
            grbx_subjects.Hide();
        }

        private void lsbx_students_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_get_name.Text = (lsbx_students.SelectedItem as Student).Name + " " + (lsbx_students.SelectedItem as Student).Surname;




            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";


            string SesQuery = "SELECT ID AS SesID, Name AS SesName FROM Sessions";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();


            grbx_subjects.Show();

            

          
            SqlCommand cmbxSession = new SqlCommand(SesQuery, sqlConnection);

            SqlDataReader SesReader = cmbxSession.ExecuteReader();
            DataTable sesTable = new DataTable();

            sesTable.Columns.Add("SesID", typeof(string));
            sesTable.Columns.Add("SesName", typeof(string));

            sesTable.Load(SesReader);

            cmbx_session.ValueMember = "SesID";
            cmbx_session.DisplayMember = "SesName";
            cmbx_session.DataSource = sesTable;

            //-----------------------------------------------------------------------------------------------------------




        }

        private void cmbx_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_subject.DataSource = null;
            cmbx_subject.Items.Clear();
            string GrValue = cmbx_group.SelectedValue.ToString();

            string sesValue = cmbx_session.SelectedValue.ToString();
            List<Subjects> subjects = new List<Subjects>();
            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();


                string query = @" SELECT SB.ID AS SbID, SB.Name AS SbName FROM Subjects AS SB
                     FULL JOIN SubjectInfo AS SI
                     ON SI.SubjectID=SB.ID
                     FULL JOIN Sessions AS SES
                     ON SES.ID=SI.SessionID
                     FULL JOIN Groups AS GR
                     ON GR.ID=SI.GroupID
                     WHERE SES.ID=" + sesValue+" AND GR.ID= " + GrValue;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        using (DataTable dataTable = new DataTable())
                        {

                            while (sqlDataReader.Read())
                            {

                                //cmbx_group.DataSource = null;
                                //cmbx_group.Items.Clear();

                                Subjects subject = new Subjects()
                                {
                                    ID = int.Parse(sqlDataReader["SbID"].ToString()),
                                    Name = sqlDataReader["SbName"].ToString(),
                                    
                                };
                                subjects.Add(subject);

                            }
                        }
                    }
                }
            }
            List<SubjectCombo> subjectCombos = new List<SubjectCombo>();
            for (int i = 0; i < subjects.Count; i++)
            {
                SubjectCombo subjectCombo = new SubjectCombo();
                subjectCombo.ID = subjects[i].ID;
                subjectCombo.Name = subjects[i].Name;
                subjectCombos.Add(subjectCombo);
            }

            cmbx_subject.DataSource = subjectCombos;
            cmbx_subject.DisplayMember = "Name";

            
        }
        //--

        private void cmbx_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subValue = cmbx_session.SelectedValue.ToString();
        }

        private void btn_pount_add_Click(object sender, EventArgs e)
        {
            try
            {
                //string GrValue = cmbx_group.SelectedValue.ToString();
                string stValue = (lsbx_students.SelectedItem as Student).Id.ToString();
                string sesValue = cmbx_session.SelectedValue.ToString();
                string subValue = cmbx_session.SelectedValue.ToString();

                int enterPount = int.Parse(txbx_enter_pount.Text);
                int examPount = int.Parse(txbx_exam_pount.Text);

                int resultPount = enterPount + examPount;

                string connectionString = "Data Source= DESKTOP-732SKG6; Initial Catalog=AZTU; Integrated Security=true;";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    string query = @"INSERT INTO Pounts(StudentID, SessionID, SubjectID, EnterPount, ExamPount, ResultPount) 
                        VALUES(@stid,@sesid,@subid,@p1,@p2,@psum)";

                    using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@stid", stValue.ToString());
                        sqlCommand.Parameters.AddWithValue("@sesid", sesValue.ToString());
                        sqlCommand.Parameters.AddWithValue("@subid", subValue.ToString());
                        sqlCommand.Parameters.AddWithValue("@p1", enterPount);
                        sqlCommand.Parameters.AddWithValue("@p2", examPount);
                        sqlCommand.Parameters.AddWithValue("@psum", resultPount);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Əməliyyat uğurla yerinə yetirildi");
                txbx_enter_pount.Text = "";
                txbx_exam_pount.Text = "";
            }
            catch
            {
                MessageBox.Show("Somesthing is wrong!!!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Show();
            this.Hide();
        }

        private void cmbx_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sesValue = cmbx_session.SelectedValue.ToString();
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
    }
}
