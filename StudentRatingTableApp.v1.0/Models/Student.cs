using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRatingTableApp.v1._0.Models
{
    public class Student
    {
        public int Id { get; set; }
        //public int GroupID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PaymentForm { get; set; }

        public override string ToString()
        {
            return Name + "  "+ Surname +"   " + PaymentForm;
        }

    }
}
