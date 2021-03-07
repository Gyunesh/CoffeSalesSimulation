using CoffeSalesSimulation.Abstract;
using System;

namespace CoffeSalesSimulation.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public long NationalId { get; set; }


    }
}
