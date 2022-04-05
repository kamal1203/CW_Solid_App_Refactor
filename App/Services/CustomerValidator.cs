using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services
{
    public class CustomerValidator
    {

        public static bool IsValidInput(string firname, string surname, string email, DateTime dateOfBirth)
        {
            if (string.IsNullOrEmpty(firname) || string.IsNullOrEmpty(surname))
            {
                return false;
            }

            if (!email.Contains("@") && !email.Contains("."))
            {
                return false;
            }


            if (GetAge(dateOfBirth) < 21)
            {
                return false;
            }

            return true;
        }

        private static int GetAge(DateTime dateOfBirth)
        {
            var now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day)) age--;
            return age;
        }

    }
}
