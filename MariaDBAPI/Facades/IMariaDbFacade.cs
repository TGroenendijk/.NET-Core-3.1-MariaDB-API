using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MariaDbAPI.Models;


namespace MariaDbAPI.Facades
{
    public interface IMariaDbFacade
    {

        List<Customer> GetCustomersByCity(string cityName);
    }
}
