using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monikulmiot
{
    internal class Triangle : Shape
    {
   
        public Triangle(string v)
        {
        }

        public Triangle(string v, double v1) : this(v)
        {
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
