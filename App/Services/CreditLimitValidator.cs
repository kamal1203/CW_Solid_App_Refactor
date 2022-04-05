using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Services
{
    public class CreditLimitValidator
    {


        public static bool Validate(Customer customer)
        {
            if (customer.HasCreditLimit && customer.CreditLimit < 500)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
