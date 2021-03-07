using CoffeSalesSimulation.Abstract;
using CoffeSalesSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSalesSimulation.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {
        ICustomerCheckService customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            this.customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

       
    }
}
