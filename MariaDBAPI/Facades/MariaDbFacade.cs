using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MariaDbAPI.Models;


namespace MariaDbAPI.Facades
{
    public class MariaDbFacade : IMariaDbFacade
    {

        private readonly DatabaseSettings _settings;

        public MariaDbFacade(IOptions<DatabaseSettings> settings)
        {
            _settings = settings.Value;
        }

        public List<Customer> GetCustomersByCity(string cityName)
        {
            List<Customer> customers = new List<Customer>();

            using (var connection = new MySqlConnection(_settings.Connection))
            {
                connection.Open();

                string sql = string.Format("SELECT customerNumber,contactLastName,contactFirstName,phone,addressLine1,city,postalCode,country FROM CUSTOMERS WHERE city = '{0}';", cityName);

                using (var command = new MySqlCommand(sql, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer c = new Customer();

                        c.customerNumber = reader.GetInt32(0);
                        c.contactLastName = reader.GetString(1);
                        c.contactFirstName = reader.GetString(2);
                        c.phone = reader.GetString(3);
                        c.addressLine1 = reader.GetString(4);
                        c.city = reader.GetString(5);
                        c.postalCode = reader.GetString(6);
                        c.country = reader.GetString(7);

                        customers.Add(c);
                    }
                }
            }

            return customers;
        }
    }
}
