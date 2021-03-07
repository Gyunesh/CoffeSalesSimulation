using CoffeSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSalesSimulation.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
