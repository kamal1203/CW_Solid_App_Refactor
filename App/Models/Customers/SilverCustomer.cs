using System;

namespace App.Models
{



    public class SilverCustomer : Customer
    {

        public SilverCustomer(string firstname, string surname, DateTime dateOfBirth, string emailAddress, Company company) : base(firstname, surname, dateOfBirth, emailAddress, company)
        {

        }
        public override void SetCreditLimit()
        {
            HasCreditLimit = true;
            using (var customerCreditService = new CustomerCreditServiceClient())
            {
                var creditLimit = customerCreditService.GetCreditLimit(Firstname, Surname, DateOfBirth);
                creditLimit = creditLimit * 2;
                CreditLimit = creditLimit;
            }
        }
    }
}

