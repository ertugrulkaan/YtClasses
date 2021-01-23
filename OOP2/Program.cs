using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer corporateCustomer = new CorporateCustomer() { Id=1,CustomerNumber="12345",CompanyName="Vestel",TaxNumber="1231231231"};
            IndividualCustomer individualCustomer = new IndividualCustomer() { Id=2,IdentityNumber="12312312312",CustomerNumber="12346",FirstName="Ertugrul",LastName="Ozdemir"};

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
