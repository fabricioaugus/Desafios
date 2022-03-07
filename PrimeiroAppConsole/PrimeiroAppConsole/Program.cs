using System;
namespace PrimeiroAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                menu();
                int opcao = Convert.ToByte(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        verificaParOuImpar();
                        break;
                    case 2:
                        verificaIdade();
                        break;
                    case 3:
                        calculaTabuadaN();
                        break;
                } if (opcao == 0) {
                    break;
                }
            }
            Console.WriteLine("FECHOU O PROGRAMA !!!");
            Console.Clear();

        }
        /* Método - Exercicio 1
      * Desenvolver um algoritmo console que solicite entrada de 
      * um número e ver se é par or impar
       */
        private static void verificaParOuImpar()
        {
            {

                int nPar;
                Console.WriteLine("Digite um numero para ver se ele é par ou impar: ");
                nPar = Convert.ToInt32(Console.ReadLine());

                if (nPar % 2 == 0) Console.WriteLine(" O numero é Par: {0} ", nPar);

                else Console.WriteLine(" O numero é impar: {0}", nPar);


            }
        }
        /* Método - Exercicio 2
        *Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
        *se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou  igual a 18 anos exiba
        *na cor verde “Permissão concedida”.
       */

        private static void verificaIdade()
        {
            int idade;
            string corVermelha = "Sem Permissão";
            string corVerde = "Permissão Concedida";

            Console.WriteLine("Digite a sua idade, você pode ou não ter permissão:");

            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18) Console.WriteLine(corVerde);
            else Console.WriteLine(corVermelha);

        }
        /* Método - Exercicio 3
             Leia 1 valor inteiro "N" (entre 2 e 1.000), e a seguir mostre a tabuada de "N".
         * Exemplo: 1 X N = N | 2 x N = 2N ….
        */
        private static void calculaTabuadaN()
        {

            Console.WriteLine("digite um numero para retornar a tabuada Dele : ");
            int numeroN = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int tabuada = i * numeroN;
                Console.WriteLine("{0} X {1} = {2}", i, numeroN, tabuada);
            }

        }
       // menu de opcões 
        private static void menu()
        {
            Console.WriteLine("\t\t\t ---- escolha uma das opções abaixo: ---- ");
            Console.WriteLine("\t\t\t 1 - Ver se o número é Par ou Impar ");
            Console.WriteLine("\t\t\t 2 - Verificar se você é maior de idade ");
            Console.WriteLine("\t\t\t 3 - Tabuada de um numero N");

            Console.WriteLine("\t\t\t 0 - Sair do programa");



        }
    }
}

