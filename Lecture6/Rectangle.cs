using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Rectangle : IPolygon, IColor
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name=value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            get => _numOfSides;
            private set => _numOfSides=value;
        }
        public void calculateArea(int []sides)
        {
            int area = sides[0] * sides[1];
            Console.WriteLine("Area of Rectangle : " + area);
        }
        public void getColor()
        {
            Console.WriteLine("Red Ractangle");
        }
        public Rectangle() => _numOfSides = 4;
    }
}
