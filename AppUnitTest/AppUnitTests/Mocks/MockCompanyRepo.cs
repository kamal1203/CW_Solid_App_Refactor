using App;
using App.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppUnitTests.Mocks
{
    internal class MockCompanyRepo : ICompanyRepo
    {
        public Company GetById(int id)
        {

            return new Company() { Id = 3, Name = "Test Company", Classification = Classification.Silver };
        }
    }
}
