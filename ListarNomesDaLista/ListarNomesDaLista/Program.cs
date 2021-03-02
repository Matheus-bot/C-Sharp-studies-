using System;
using System.Collections.Generic;

namespace ListarNomesDaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "Ana", "Beatriz", "Carla", "Evelyn", "Fátima" };

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            
            Console.ReadKey();
        }
    }
}
