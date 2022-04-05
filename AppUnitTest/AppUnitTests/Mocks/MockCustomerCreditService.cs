using App;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppUnitTests.Mocks
{
    internal class MockCustomerCreditService : ICustomerCreditService
    {
        public int GetCreditLimit(string firstname, string surname, DateTime dateOfBirth)
        {
            return 1000;

        }
    }
}
