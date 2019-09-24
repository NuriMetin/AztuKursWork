using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRatingTableApp.v1._0.Forms;
using StudentRatingTableApp.v1._0.Forms.ReytingForms;
using StudentRatingTableApp.v1._0.Forms.AddingForms;
using StudentRatingTableApp.v1._0.Forms.ReytingForms.GroupsRating;
using StudentRatingTableApp.v1._0.Forms.ReytingForms.ProfessionsRating;

namespace StudentRatingTableApp.v1._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
