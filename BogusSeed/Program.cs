using Bogus;
using BogusSeed.Models;
using BogusSeed.Utilities.BogusCustomers;

namespace BogusSeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generera 10 kunder
            var customers = SeedBogusCustomers.Create(10);

            // Skriv ut kunderna
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}, Name: {customer.Name}, Email: {customer.Email}, Phone: {customer.PhoneNumber}, DOB: {customer.DateOfBirth.ToShortDateString()}");
            }
        }
    }
}
