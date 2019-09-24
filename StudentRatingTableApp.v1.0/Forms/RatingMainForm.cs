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
using StudentRatingTableApp.v1._0.Forms;
using StudentRatingTableApp.v1._0.Forms.AddingForms;
using StudentRatingTableApp.v1._0.Forms.ReytingForms;
using StudentRatingTableApp.v1._0.Forms.AddingForms;
using StudentRatingTableApp.v1._0.Forms.ReytingForms.GroupsRating;
using StudentRatingTableApp.v1._0.Forms.ReytingForms.ProfessionsRating;
namespace StudentRatingTableApp.v1._0.Forms
{
    public partial class RatingMainForm : Form
    {
        public RatingMainForm()
        {
            InitializeComponent();
        }

        private void qrupaGörəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRatingForm studentRatingForm = new StudentRatingForm();
            studentRatingForm.Show();
            this.Hide();
        }

        private void ixtisasaGörəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentRatingForProfession studentRatingForProfession = new StudentRatingForProfession();
            studentRatingForProfession.Show();
            this.Hide();
        }

        private void fakultəyəGörəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsForFaculty groupsForFaculty = new GroupsForFaculty();
            groupsForFaculty.Show();
            this.Hide();
        }

        private void universitetəGörəToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RatingForUniversityForm ratingForUniversityForm = new RatingForUniversityForm();
            ratingForUniversityForm.Show();
            this.Hide();
        }

        private void ixtisasaGörəToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupsRatingForProfession groupsRatingForProfession = new GroupsRatingForProfession();
            groupsRatingForProfession.Show();
            this.Hide();
        }

        private void fakultəyəGörəToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupsRatingForFaculty groupsRatingForFaculty = new GroupsRatingForFaculty();
            groupsRatingForFaculty.Show();
            this.Hide();
        }

        private void universitetəGörəToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupsRatingForUniversity groupsRatingForUniversity = new GroupsRatingForUniversity();
            groupsRatingForUniversity.Show();
            this.Hide();
        }

        private void fakultəyəGörəToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProfessionsRatingForFaculty professionsRatingForFaculty = new ProfessionsRatingForFaculty();
            professionsRatingForFaculty.Show();
            this.Hide();
        }

        private void universitetəGörəToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProfessionsRatingForUniversity professionsRatingForUniversity = new ProfessionsRatingForUniversity();
            professionsRatingForUniversity.Show();
            this.Hide();
        }

        private void fakultələrarasıReytinqCəvəliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultiesRating facultiesRating = new FacultiesRating();
            facultiesRating.Show();
            this.Hide();
        }

        private void qrupRedakteEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Hide();
        }

        private void qrupElaveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.Show();
            this.Hide();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            this.Hide();
        }
    }
}
