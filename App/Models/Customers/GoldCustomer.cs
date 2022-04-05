using System;

namespace App.Models
{
    public class GoldCustomer : Customer
    {

        public GoldCustomer(string firstname, string surname, DateTime dateOfBirth, string emailAddress, Company company) : base(firstname, surname, dateOfBirth, emailAddress, company)
        {

        }

        public override void SetCreditLimit()
        {
            HasCreditLimit = false;
        }
    }
}
