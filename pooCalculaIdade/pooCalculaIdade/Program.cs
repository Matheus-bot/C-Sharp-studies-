using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa ");
            Console.WriteLine("Nome da pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa p;
            p = new Pessoa(nome,ano);
            p.ExbirDados();
           Convert.ToD
            Console.ReadKey();
        }
    }
}
