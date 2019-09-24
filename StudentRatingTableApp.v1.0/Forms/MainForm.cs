


using StudentRatingTableApp.v1._0.Forms;
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

namespace StudentRatingTableApp.v1._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

        private void btn_admin_login_Click(object sender, EventArgs e)
        {

            //    string connect = "Data Source=DESKTOP-6D6VFHT;Initial Catalog=AZTU;Integrated Security=true;";
            //    string query = @"SELECT Name, Password FROM Users WHERE Name=@p1 AND Password=@p2";
            //    SqlConnection sqlConnection = new SqlConnection(connect);
            //    sqlConnection.Open();
            //    SqlCommand sqlCommand = new SqlCommand(query);
            //    sqlCommand.Parameters.AddWithValue("p1", txbx_admin_username);
            //    sqlCommand.Parameters.AddWithValue("p2", txbx_admin_password);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //    if (sqlDataReader.Read())
            //    {
            RatingMainForm ratingMainForm = new RatingMainForm();
            ratingMainForm.Visible = true;
            this.Visible = false;

            //    sqlDataReader.Close();
            //    sqlCommand.Dispose();
            //    sqlConnection.Close();
            //}


            //else
            //{
            //    MessageBox.Show("Istifadeci adi ve yaxud Sifre yanlisdir...");
            //    txbx_admin_username.Clear();
            //    txbx_admin_password.Clear();
            //    txbx_admin_username.Focus();
            //}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
