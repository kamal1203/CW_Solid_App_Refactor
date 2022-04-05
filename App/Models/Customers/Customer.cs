using System;

namespace App
{
    public abstract class Customer
    {
        public Customer(string firstname, string surname, DateTime dateOfBirth, string emailAddress, Company company)
        {
            Firstname = firstname;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            Company = company;


            //inject credit service
            //creditservice 
           

            

            SetCreditLimit();
        }

        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string EmailAddress { get; set; }

        public bool HasCreditLimit { get; set; }

        public int CreditLimit { get; set; }

        public Company Company { get; set; }

        public ICustomerCreditService CreditService;



        public abstract void SetCreditLimit();



    }

}