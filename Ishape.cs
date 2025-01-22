using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_interface
{
    internal interface Ishape
    {
        public int Area { get; set; }

        public void DisplayShapeInfo();

    }
    class Circle : Ishape
    {
        public int x;
        public Circle(int x)
        {
            this.x = x;

        }

        public int Area
        {
            get { return (22 / 7) * (x * x); }
            set { x = value; }
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Area of Circle= {Area}");
        }

    }
    class Rectangle : Ishape
    {

        public int weight;
        public int height;
        public int Area
        {
            get { return weight * height; }
            set
            {
                weight = value;
                height = value;
            }
        }
        public Rectangle(int weight, int height)
        {
            this.weight = weight;
            this.height = height;

        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($" Area of Rectangle= {Area}");
        }

    }
}
