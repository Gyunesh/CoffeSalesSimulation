using CoffeSalesSimulation.Abstract;
using CoffeSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSalesSimulation.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
