using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int Grade { get; set; }
        public string Id { get; set; }
        public int MonthlyPaid { get; set; }
        public int StudentCount { get; set; }

        public SchoolClass(int year, string identifier, int monthlyFee, int studentCount)
        {
            Grade = year;
            Id = identifier;
            MonthlyPaid = monthlyFee;
            StudentCount = studentCount;
        }

        public override string ToString()
        {
            return $"{Grade}. {Id} ({MonthlyPaid} Ft)";
        }
    }
}
