using System;
namespace PrimeiroAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Digite sua Nome:");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua idade:");
            idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" Olá eu sou {0} e tenho {1} anos ", nome, idade);


        }

    }
    
}
