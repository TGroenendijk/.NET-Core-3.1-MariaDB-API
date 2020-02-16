using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MariaDbAPI.Models
{
    public class Customer
    {
        public int customerNumber { get; set; }
        public string contactLastName { get; set; }
        public string contactFirstName { get; set; }
        public string phone { get; set; }
        public string addressLine1 { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }
}
