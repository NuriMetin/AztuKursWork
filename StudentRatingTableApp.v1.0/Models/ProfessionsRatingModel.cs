using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingTableApp.v1._0.Models
{
    public class ProfessionsRatingModel
    {
        public string Profession_Name { get; set; }
        public int Profession_Result { get; set; }

        public override string ToString()
        {
            return Profession_Name + "  " + Convert.ToString(Profession_Result);
        }
    }
}
