using Bogus;
using BogusSeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogusSeed.Utilities.BogusCustomers
{
    internal class SeedBogusCustomers
    {
        public static List<Customer> Create(int customerNum)
        {
            // Skapa en Faker för Customer
            var customerFaker = new Faker<Customer>()
                .RuleFor(c => c.CustomerId, f => f.IndexFaker + 1) // Automatiskt ID från 1 och uppåt
                .RuleFor(c => c.Name, f => f.Name.FullName()) // Fullständigt namn
                .RuleFor(c => c.Email, f => f.Internet.Email()) // Giltig e-postadress
                .RuleFor(c => c.PhoneNumber, f => "0" + f.Random.Number(100000000, 999999999)) // Telefonnummer börjar med 0
                .RuleFor(c => c.DateOfBirth, f => f.Date.Past(100, DateTime.Now.AddYears(-18))); // Ålder mellan 18-100 år

            // Generera 10 kunder
            return customerFaker.Generate(customerNum);
        }
    }
}
