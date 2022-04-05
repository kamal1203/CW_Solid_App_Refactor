using App;
using App.Data;
using App.Data.CustomerData;
using AppUnitTests.Mocks;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using static App.CustomerRepo;

namespace AppUnitTests
{
    public class Tests
    {



        [SetUp]
        public void Setup()
        {


        }

        [Test]
        public void TestAddCustomer()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddTransient<ICompanyRepo, MockCompanyRepo>();
            services.AddTransient<ICustomerRepo, CustomerRepo>();


            var serviceProvider = services.BuildServiceProvider();




            var customerrepo = serviceProvider.GetService<ICustomerRepo>();
            var companyRepo = serviceProvider.GetService<ICompanyRepo>();

            CustomerService customerService = new CustomerService(companyRepo, customerrepo);

            bool passed = customerService.AddCustomer("kamal", "al khafaaji", "ster1203@gmail.com", DateTime.Today.AddYears(-54), 3);




            if (passed)
            {

            Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}