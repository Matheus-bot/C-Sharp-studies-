using System;

namespace VeridicarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade");
            int idade = -1;

            if (!int.TryParse(Console.ReadLine(), out idade))
                Console.WriteLine("Idade inválida");
            else
            {
                VerificacaoPorSwitch(idade);
                VerificacaoPorIf(idade);
            }

        }

        static void VerificacaoPorSwitch(int idade)
        {
            Console.WriteLine("Feito por VerificacaoPorSwitch");

            switch (idade)
            {
                case int i when (i < 0):
                    Console.WriteLine("Idade inválida");
                    break;
                case 0:
                    Console.WriteLine("É bebezinho");
                    break;
                case int i when (i >= 1 && i <= 8):
                    Console.WriteLine("É criança");
                    break;
                case int i when (i >= 9 && i <= 12):
                    Console.WriteLine("É pre-adolescente");
                    break;
                case int i when (i >= 13 && i <= 17):
                    Console.WriteLine("É adolecente");
                    break;
                default:
                    Console.WriteLine("É adulto");
                    break;
            }
        }

        static void VerificacaoPorIf(int idade)
        {
            Console.WriteLine("Feito por VerificacaoPorIf");

            if (idade < 0)
                Console.WriteLine("Idade inválida");
            else if (idade == 0)
                Console.WriteLine("É bebezinho");
            else if (idade >= 1 && idade <= 8)
                Console.WriteLine("É criança");
            else if (idade >= 9 && idade <= 12)
                Console.WriteLine("É pre-adolescente");
            else if (idade >= 13 && idade <= 17)
                Console.WriteLine("É adolecente");
            else
                Console.WriteLine("É adulto");

        }

    }
}
}
