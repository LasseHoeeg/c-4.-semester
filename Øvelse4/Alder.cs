using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    internal class Alder
    {
        public static void CalculateAge(DateTime BirthDateInput, out int age) {
            age = DateTime.Now.Year - BirthDateInput.Year;
        }

        public static void CalculateAge2(DateTime BirthDateInput, out int age)
        {
            age = DateTime.Now.Year - BirthDateInput.Year;
            int month = DateTime.Now.Month - BirthDateInput.Month;
            if (month < 0)
            {
                age = DateTime.Now.Year - BirthDateInput.Year - 1;

            }
            else if (month == 0)
            {
                int days = DateTime.Now.Day - BirthDateInput.Day;
                if (days < 0)
                {
                    age = DateTime.Now.Year - BirthDateInput.Year - 1;
                }
            }
        }
    }
 }
