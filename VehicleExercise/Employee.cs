using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Employee: Person
    {
        private string id;
        public Employee()
        {
            this.id = "123456789";
       }

        public Employee(string name, string id) : base(name)
        {
            this.id=id; 
        }

        public override bool Equals(object? obj)


        {
            return obj is Employee employee &&
                   name == employee.name &&
                   id == employee.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, id);
        }

        public override string? ToString()
        {
           return $"{this.name}, {this.id}";

            //return $"{base.ToString()}, {this.id}";
        }


    }

}
