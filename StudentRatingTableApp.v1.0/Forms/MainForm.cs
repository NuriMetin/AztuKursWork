


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
            if (txbx_admin_username.Text== "nurimetin98@gmail.com" && txbx_admin_password.Text=="Metin1998*#")
            {
                RatingMainForm ratingMainForm = new RatingMainForm();
                ratingMainForm.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Istifadeci adi ve yaxud Sifre yanlisdir...");
                txbx_admin_username.Clear();
                txbx_admin_password.Clear();
                txbx_admin_username.Focus();
            }
        }

    }
}
