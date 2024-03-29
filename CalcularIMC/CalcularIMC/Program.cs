﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu peso em Kg: ");
            double peso = double.Parse(Console.ReadLine()); // parse converte uma string em double 

            Console.Write("Qual sua altura em metros:");
            double altura = double.Parse(Console.ReadLine());

            double valorIMC = peso / (altura * altura);

            if (valorIMC < 20)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " --> Abaixo do peso.");
            }
            else if ((valorIMC >= 20) && (valorIMC <= 24))
            {
                Console.WriteLine("\nIMC = " + valorIMC + " --> Peso ideal.");
            }
            else if ((valorIMC >= 25) && (valorIMC <= 29))
            {
                Console.WriteLine($"\nIMC = {valorIMC} --> Acima do peso.");
            }
            else if ((valorIMC >= 30) && (valorIMC <= 34))
            {
                Console.WriteLine($"\nIMC = {valorIMC} --> Obeso.");
            }
            else if (valorIMC > 24)
            {
                Console.WriteLine("\nIMC = " + valorIMC + " --> Obesidade mórbida!! ");
            }
            else {
                Console.WriteLine("Calculo Indísponível");
            }

            Console.ReadKey();
        }
    }
}
