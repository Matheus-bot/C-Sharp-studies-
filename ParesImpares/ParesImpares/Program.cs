using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParesImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> parOuImpar = new List<int> { 1, 2, 3, 4, 5,
                6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int num = parOuImpar.ToList;
            int impar = 0;
            int par = 0;

            if ((num % 2) == 0)
            {
                impar ++;
                Console.WriteLine("Numeros Impares: " + impar);
            }
            else
            {
                par ++;
                Console.WriteLine("Numeros Pares " + par);
            }
        }
    }
}
