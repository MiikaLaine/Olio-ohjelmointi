using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayapinta
{
    class Customer
    {
        public string Name { get; set; }
        public double Purchases { get; set; }

        public Customer(string name, double purchases)
        {
            Name = name;
            Purchases = purchases;
        }

        public double GetBonus()
        {
            if (Purchases <= 1000)
            {
                return 0.02 * Purchases;
            }
            else if (Purchases <= 2000)
            {
                return 0.03 * Purchases;
            }
            else
            {
                return 0.05 * Purchases;
            }
        }

        public override string ToString()
        {
            return $"Nimi: {Name}, Ostot: {Purchases}, Bonus: {GetBonus()}";
        }
    }
}