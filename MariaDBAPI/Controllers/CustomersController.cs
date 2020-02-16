using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MariaDbAPI.Models;
using MariaDbAPI.Facades;


namespace MariaDbAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : Controller
    {
        public IMariaDbFacade Database { get; set; }
        private readonly ILogger<CustomersController> _logger;


        public CustomersController(IMariaDbFacade database, ILogger<CustomersController> logger)
        {
            Database = database;
            _logger = logger;
        }

        
        /*
        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }
        */

        [HttpGet]
        [Route("city/{cityName}")]
        public IEnumerable<Customer> Get(string cityName)
        {
            List<Customer> customers = Database.GetCustomersByCity(cityName);

            return customers;
        }
    }
}
