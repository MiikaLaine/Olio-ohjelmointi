using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monikulmiot
{
    internal class Circle : Shape
    {
      

        public Circle(string v1, double v2)
        {
        }

        public override double GetArea()
        {
            return 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string GetInfo()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
