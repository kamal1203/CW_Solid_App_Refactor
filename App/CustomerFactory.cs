using App.Models;
using System;

namespace App
{
    class CustomerFactory
    {

        public static Customer GetCustomer(string firstname, string surname, DateTime dateOfBirth, string emailAddress, Company company)
        {
            Customer instance;
            try
            {
                switch (company.Classification)
                {

                    case Classification.Bronze:
                        instance = new BronzeCustomer(firstname, surname, dateOfBirth, emailAddress, company);
                        break;

                    case Classification.Silver:
                        instance = new SilverCustomer(firstname, surname, dateOfBirth, emailAddress, company);
                        break;
                    case Classification.Gold:
                        instance = new GoldCustomer(firstname, surname, dateOfBirth, emailAddress, company);
                        break;
                    default:
                        throw new NotImplementedException("Classification not implemented");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error creating customer", ex);
            }
            return instance;

        }



    }
}
