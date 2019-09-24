using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingTableApp.v1._0.Models
{
    public class FacultyRatingModel
    {
        public string Faculty_Name { get; set; }
        public int Faculty_Avg_Pounts { get; set; }

        public override string ToString()
        {
            return Faculty_Name + "  " + Convert.ToString(Faculty_Avg_Pounts);
        }
    }
}
