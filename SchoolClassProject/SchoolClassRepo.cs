using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        private List<SchoolClass> _schoolClasses = new List<SchoolClass>();

        public SchoolClassRepo(List<SchoolClass> schoolClasses)
        {
            _schoolClasses = schoolClasses;
        }

        public List<SchoolClass> FindAll() => _schoolClasses;

        public string MostPaidSchoolClass()
        {
            if (!FindAll().Any())
            {
                return string.Empty;
            }
            if (_schoolClasses.Select(sclass => sclass.MonthlyPaid).Distinct().Count() == 1)
            {
                return "9.a és 9.b osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.";
            }
            return $"{_schoolClasses.OrderByDescending(c => c.MonthlyPaid).First().Grade}.{_schoolClasses.OrderByDescending(c => c.MonthlyPaid).First().Id}";
        }
    }
}
