using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            grades.Add(5);
            grades.Add(10);

            Console.WriteLine(grades[0]); //se colocarmos o numero 1 ele carrega a posição 2 que no casso é o número 10
            -----------------------------------------------------------------------------------
            //List<int> grades = new List<int>() { 5, 10 };
            //grades.Add(30);
            //grades.Insert(2, 15);
            //grades.Remove(10); // 5 15 30 -> remove o número 10 da lista

            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[1]);
            //Console.WriteLine(grades[2]);
            -----------------------------------------------------------------------------------
            //Encontrando um numero da lista 
            //List<int> grades = new List<int>() { 5, 10, 26, 34, 2, 23, 200 };
            //if (grades.Contains(5))
            //{
            //    Console.WriteLine("Found ");
            //}
            //else
            //{
            //    Console.WriteLine("That´s not here ");
            //}
            //Console.ReadKey();

            ---------------------------------------------------------------------------------
            // Comparar se o valor da lista  são os mesmos
            //            List<int> grades1 = new List<int>() { 5, 10, 26, 26, 26, 34, 2, 23, 26, 200 };
            //List<int> grades2 = new List<int>() { 5, 10, 26, 26, 26, 34, 2, 23, 26, 200 };

            //if (grades1.SequenceEqual(grades2))
            //{
            //    Console.WriteLine("Equal ! ");
            //}
            ---------------------------------------------------------------------------------
            //Imprime o dobro de todos os números da lista com for 
            //            List<int> grades = new List<int>() { 5, 10, 26, 26, 26, 34, 2, 23, 26, 200 };

            //for (int i = 0; i < grades.Count; i++)
            //{
            //    grades[i] *= 2;
            //    Console.WriteLine(grades[i]);
            //}
            --------------------------------------------------------------------------------
            //Imprime o dobro de todos os números da lista com o foreach

            //List<int> grades = new List<int>() { 5, 10, 26, 26, 26, 34, 2, 23, 26, 200 };

            ////foreach int grade in grades do something 
            //foreach (int grade in grades)
            //{

            //    Console.WriteLine(grade * 2);
            //}
        }
    }
}
