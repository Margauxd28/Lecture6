using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Triangle:IPolygon, IColor
    {
        private string _name;
        public string Name
        {
            get=>_name;
            set=>_name=value;
        }
        private int _numOfSides;
        public int NumOfSides
        {
            get => _numOfSides;
            private set => _numOfSides = value;
        }
        public void calculateArea(int[] sides)
        {
            var s = (sides[0] + sides[1]+sides[2])/2;
            double area = Math.Sqrt(s * (s - sides[0]) * (s - sides[1]) * (s - sides[2]));
            Console.WriteLine("Area of triangle is : "+area);
        }
        public void getColor()
        {
            Console.WriteLine("Green triangle");
        }
        public Triangle() => _numOfSides = 3;
    }
}
