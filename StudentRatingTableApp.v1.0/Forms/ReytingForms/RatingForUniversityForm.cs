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

namespace StudentRatingTableApp.v1._0.Forms
{
    public partial class RatingForUniversityForm : Form
    {
        public RatingForUniversityForm()
        {
            InitializeComponent();
        }

        private void RatingForUniversityForm_Load(object sender, EventArgs e)
        {
            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";
   

            string SesQuery = "SELECT ID AS SesID, Name AS SesName FROM Sessions";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            SqlCommand cmbxSession = new SqlCommand(SesQuery, sqlConnection);

            SqlDataReader SesReader = cmbxSession.ExecuteReader();
            DataTable sesTable = new DataTable();

            sesTable.Columns.Add("SesID", typeof(string));
            sesTable.Columns.Add("SesName", typeof(string));

            sesTable.Load(SesReader);

            this.cmbxSession.ValueMember = "SesID";
            this.cmbxSession.DisplayMember = "SesName";
            this.cmbxSession.DataSource = sesTable;

            sqlConnection.Close();


        }

        private void cmbxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SesValue = cmbxSession.SelectedValue.ToString();


            List<FinishResult> allFinishResults = new List<FinishResult>();
            string conString = "Data Source= DESKTOP-732SKG6;Initial Catalog=AZTU;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();


                string query = @"SELECT  Stud.Name AS [Student Name] ,  AVG(Pounts.ResultPount) AS SessiounAVGPounts
                    FROM Students as Stud
                    INNER JOIN Groups AS GR
                    ON GR.ID=Stud.GroupID
                    INNER JOIN Pounts
                    ON Pounts.StudentID = Stud.ID
                    INNER JOIN Sessions
                    ON SessionID = Pounts.SessionID
                    INNER JOIN Subjects
                    ON Pounts.SubjectID = Subjects.ID
                    WHERE  SessionID=" + SesValue + " Group by Stud.Name ORDER BY SessiounAVGPounts DESC";
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
                                    SudentName = sqlDataReader["Student Name"].ToString(),
                                    Results = int.Parse(sqlDataReader["SessiounAVGPounts"].ToString())
                                };
                                allFinishResults.Add(allFinishResult);


                            }
                            dtgv_rating_all.DataSource = allFinishResults;


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
