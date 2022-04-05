using App.Data;
using App.Data.CustomerData;
using App.Services;
using System;

namespace App
{
    public class CustomerService : ICustomerService
    {
        ICompanyRepo _CompanyRep;
        ICustomerRepo _CustomerService;
        public CustomerService(ICompanyRepo Companyrep, ICustomerRepo CustomerRep)
        {
            _CompanyRep = Companyrep;
            _CustomerService = CustomerRep;
        }

        public bool AddCustomer(string firname, string surname, string email, DateTime dateOfBirth, int companyId)
        {
            //validate input
            try
            {


                if (!CustomerValidator.IsValidInput(firname, surname, email, dateOfBirth))
                    return false;


                Company company = _CompanyRep.GetById(companyId);
                var customer = CustomerFactory.GetCustomer(firname, surname, dateOfBirth, email, company);


                if (!CreditLimitValidator.Validate(customer))
                    return false;
                

                _CustomerService.AddCustomer(customer);

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





    }
}
