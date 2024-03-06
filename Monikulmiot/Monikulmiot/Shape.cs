using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monikulmiot
{
    abstract class Shape :IComparable<Shape>    
    {
        protected enum Shapetype {Undefined=0, Circle=1, Triangle=2, Rectangle=3};
        
        public enum Color {Undefined = 0, Red = 1, Blue = 2, Green = 3};

        protected Shapetype type;
        protected Color color;
        protected string name;
        public abstract double GetArea();
        public abstract string GetInfo();

        public string GetColor()
        {
        return this.GetColor();
        }

        public int CompareTo(Shape other)
        {
            throw new NotImplementedException();
        }
    }
}