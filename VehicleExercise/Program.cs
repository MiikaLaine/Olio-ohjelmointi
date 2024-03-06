using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEmployee e");
            Employee e1 = new Employee("Kalle Korkki","1234");
            Console.WriteLine("e.ToString()" + e1);

            Console.WriteLine("\nEmployee Päällikkö");
            Employee e2 = new Employee("Hornan Late", "4321");
            Console.WriteLine("e.ToString()" + e2);
            Console.WriteLine("\n");
            if (e1.Equals(e2)) 
            {
                Console.WriteLine($"{e1} ja {e2} ovat yhtäsuuria");
            }
            else 
            {
            Console.WriteLine($"{e1} ja {e2} eivät ole yhtäsuuria");
            }

        
            Person p1 = new Person("Jeesus Nasaretilainen");
            // Employee? eTest = p1 as Employee; <-- ei onnistu
            //Console.WriteLine("onnistuuko tulostus:" + eTest?.ToString());
            Person e1Test = e1 as Person;
            
            
            
            Console.ReadLine(); 




        }

    }
   
}
