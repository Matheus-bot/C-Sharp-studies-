using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 9; i >= 0; i--)
            {
                for (int K = 9; K >= 0; K--) //colocar  i ao invés do 9, para formar um triângulo
                {
                    Console.Write(K + " ");
                }
                Console.WriteLine();
            }*/
             //  Triângulo com o while
                 int i = 9;
                 while (i >= 0)
                 {
                     int k = i;
                     while (k >= 0)
                     {
                         Console.Write(k + " ");
                         k--;
                     }
                     Console.WriteLine();
                     i--;
             }
            //// Triângulo com o for
            // for (int i = 9; i >= 0; i--)
            //     {
            //         for (int k = i; k >= 0; k--)
            //         {
            //             Console.Write(k + " ");
            //         }
            //         Console.WriteLine();
            //     }
            // Console.ReadKey();
        }
    }
}
