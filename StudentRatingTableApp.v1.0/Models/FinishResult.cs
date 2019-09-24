using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingTableApp.v1._0.Models
{
     public class FinishResult
    {
        public string SudentName { get; set; }
        public int Results { get; set; }
        

        public override string ToString()
        {
            return SudentName + "  " + Convert.ToString(Results);
        }

    }
}
