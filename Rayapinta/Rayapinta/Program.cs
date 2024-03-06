using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayapinta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a store
            Store store = new Store("Makkosen valinta", 10000);

            // Add products
            store.AddProduct(new Product("Omena", 1.2, 5));
            store.AddProduct(new Product("Banaani", 0.8, 3));
            store.AddProduct(new Product("Appelsiini", 1.5, 4));

            // Add customers
            store.AddCustomer(new Customer("Repe", 800));
            store.AddCustomer(new Customer("Arska", 1500));
            store.AddCustomer(new Customer("Bob", 2500));

            // Print store information
            Console.WriteLine(store);

            // Print products and customers
            store.PrintProducts();
            store.PrintCustomers();

            Console.ReadLine();
        }
    }
}
