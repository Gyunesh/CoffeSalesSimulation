using CoffeSalesSimulation.Abstract;
using CoffeSalesSimulation.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeSalesSimulation.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(customer.NationalId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}
