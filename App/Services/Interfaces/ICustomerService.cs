using System;

namespace App
{
    internal interface ICustomerService
    {

        bool AddCustomer(string firname, string surname, string email, DateTime dateOfBirth, int companyId);
    }
}
