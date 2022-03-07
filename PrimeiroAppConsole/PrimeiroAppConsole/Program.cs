using System;
namespace PrimeiroAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                Menu();
                int opcao = Convert.ToByte(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                       Console.WriteLine("Digite um número, para ver se ele é par ou impar: ");
                       int NumeroParOuImpar = Convert.ToInt32(Console.ReadLine());
                       VerificaParOuImpar(NumeroParOuImpar);
                       break;
                    case 2:
                        Console.WriteLine("Digite a sua idade, você pode ou não ter permissão:");
                        int IdadeParaSerVerificada = Convert.ToInt32(Console.ReadLine());
                        VerificaIdade(IdadeParaSerVerificada);
                        break;
                    case 3:
                       Console.WriteLine("digite um numero para retornar a tabuada Dele : ");
                       int NumeroLida = Convert.ToInt32(Console.ReadLine());
                       CalculaTabuadaN(NumeroLida);
                        break;
                } if (opcao == 0) {
                    break;
                }
            }
            Console.WriteLine("FECHOU O PROGRAMA !!!");

        }
        /* Método - Exercicio 1
      * Desenvolver um algoritmo console que solicite entrada de 
      * um número e ver se é par or impar
       */
        private static void VerificaParOuImpar(int nParOuImpar)
        {
            {
                if (nParOuImpar % 2 == 0) Console.WriteLine(" O número {0} é Par", nParOuImpar);

                else Console.WriteLine(" O número {0} é Impar", nParOuImpar);
            }
        }
        /* Método - Exercicio 2
        *Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
        *se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou  igual a 18 anos exiba
        *na cor verde “Permissão concedida”.
       */

        private static void VerificaIdade(int idade)
        {
            string corVermelha = "Sem Permissão";
            string corVerde = "Permissão Concedida";

            if (idade >= 18) Console.WriteLine(corVerde);
            
            else Console.WriteLine(corVermelha);

        }
        /* Método - Exercicio 3
             Leia 1 valor inteiro "N" (entre 2 e 1.000), e a seguir mostre a tabuada de "N".
         * Exemplo: 1 X N = N | 2 x N = 2N ….
        */
        private static void CalculaTabuadaN(int numeroN)
        {
            for (int i = 1; i <= 10; i++)
            {
                int tabuada = i * numeroN;
                Console.WriteLine("{0} X {1} = {2}", i, numeroN, tabuada);
            }

        }
       // menu de opcões 
        private static void Menu()
        {
            Console.WriteLine("\t\t\t ---- escolha uma das opções abaixo: ---- ");
            Console.WriteLine("\t\t\t 1 - Ver se o número é Par ou Impar ");
            Console.WriteLine("\t\t\t 2 - Verificar se você é maior de idade ");
            Console.WriteLine("\t\t\t 3 - Tabuada de um numero N");

            Console.WriteLine("\t\t\t 0 - Sair do programa");



        }
    }
}

