using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayapinta
{
    class Store : IProducts, ICustomers
    {
        public string Name { get; set; }
        public double Revenue { get; set; }
        private List<Product> products;
        private List<Customer> customers;

        public Store(string name, double revenue)
        {
            Name = name;
            Revenue = revenue;
            products = new List<Product>();
            customers = new List<Customer>();
        }

        // Implementing IProducts interface method
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // Implementing IProducts interface method
        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteet kaupassa '{Name}':");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.CalculateTotal();
            }
            Console.WriteLine($"Yhteishinta: {totalValue}");
            Console.WriteLine();
        }

        // Implementing ICustomers interface method
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        // Implementing ICustomers interface method
        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakkaita liikkeessä '{Name}':");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine($"Asiakkaiden kokonaismäärä: {customers.Count}");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Liikkeen nimi: {Name}, Tuotto: {Revenue}, Asiakkaiden lukumäärä: {customers.Count}, Tuotteiden määrä: {products.Count}";
        }
    }
}