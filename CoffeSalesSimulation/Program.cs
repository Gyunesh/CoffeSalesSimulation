using CoffeSalesSimulation.Abstract;
using CoffeSalesSimulation.Adapters;
using CoffeSalesSimulation.Concrete;
using CoffeSalesSimulation.Entities;

namespace CoffeSalesSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = 1997, FirstName = "ali", LastName = "veli", NationalId = 123456 });
            

            
    {

    }
        }
    }


}
