using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var age = 25;
            Console.WriteLine("var holds TYPE:{0}|VAL:{1}", age.GetType(), age);
            var name = "Margaux";
            Console.WriteLine("var holds TYPE:{0}|VAL:{1}", name.GetType(), name);

            int[] odds = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("var holds an array of numbers");
            foreach (var num in odds) { Console.WriteLine("TYPE:{ 0}| VAL:{1}", num.GetType(), num); }*/

            //int i = 75;
            //float f = 53.005f;
            //double d = 2345.7652;
            //bool b = true;

            //Console.WriteLine(i.ToString());
            //Console.WriteLine(f.ToString());
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(b.ToString());

            Rectangle r1 = new Rectangle();
            r1.Name = "rectangle_1";
            r1.calculateArea(new int[] { 100, 200 });
            r1.getColor();

            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] { 100, 200, 300 });
            t1.getColor();

            Console.ReadKey();
        }
    }
}
