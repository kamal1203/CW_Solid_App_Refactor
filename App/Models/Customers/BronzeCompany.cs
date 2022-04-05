using System;

namespace App.Models
{
    public class BronzeCustomer : Customer
    {

        public BronzeCustomer(string firstname, string surname, DateTime dateOfBirth, string emailAddress, Company company) : base(firstname, surname, dateOfBirth, emailAddress, company)
        {

        }

        public override void SetCreditLimit( )
        {

            
            // Do credit check
            HasCreditLimit = true;

            var creditLimit = customerCreditService.GetCreditLimit.GetCreditLimit(Firstname, Surname, DateOfBirth);
                    CreditLimit = creditLimit;

            using (var customerCreditService = new CustomerCreditServiceClient())
            {
                var creditLimit = customerCreditService.GetCreditLimit(Firstname, Surname, DateOfBirth);
                CreditLimit = creditLimit;
            }
        }
    }
}
