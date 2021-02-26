using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const double PI = 3.14;
            double radius;
            double result;

            Console.WriteLine("Input the radius of the circle : ");
            radius = Convert.ToDouble(Console.ReadLine());
            result = 2 * PI * radius;
            Console.WriteLine("Perimeter of Circle : {0}", result);
            Console.Read();
        }
    }
}
