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
                       int NumeroParOuImpar = int.Parse(Console.ReadLine());
                       VerificaParOuImpar(NumeroParOuImpar);
                       break;
                    case 2:
                        Console.WriteLine("Digite a sua idade, você pode ou não ter permissão:");
                        int IdadeParaSerVerificada = int.Parse(Console.ReadLine());
                        VerificaIdade(IdadeParaSerVerificada);
                        break;
                    case 3:
                       Console.WriteLine("digite um numero para retornar a tabuada Dele : ");
                       int NumeroLida = int.Parse(Console.ReadLine());
                       CalculaTabuadaN(NumeroLida);
                        break;

                    case 4:
                         Console.WriteLine("Leitura de Arquivos C#, Digite o caminho: ");
                           LerArquivos(1);
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
        Console.WriteLine("\t\t\t\t === A Tabuada do "+numeroN+" é === \t\t\t\t\n");
            for (int i = 1; i <= 10; i++)
            {
                int tabuada = i * numeroN;
                Console.WriteLine("{0} X {1} = {2}", i, numeroN, tabuada);
            }
        }

        private static void LerArquivos(int numeroArquivo)
        {
            //  caminho do arquivo para ser lido aki passando
            //  apenas o numero ai se tiver mais de um arquivo com exemplo report1, report2, report3,
            // esta lendo os arquivos report1, report2, report3 ... reportN 
            // Caminho que você quer que leia o arquivo
            string arquivoComCaminho = @"C:\Users\" + numeroArquivo + ".txt";
            Console.WriteLine("==== Lendo arquivo ====\n" + arquivoComCaminho + "\n=====");
            if(File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while((linha = arquivo.ReadLine()) != null)
                    {
                    Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\Users\" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }
       // menu de opcões 
        private static void Menu()
        {
            Console.WriteLine("\t\t\t ======== escolha uma das opções abaixo: ========");
            Console.WriteLine("\t\t\t 1 - Ver se o número é Par ou Impar ");
            Console.WriteLine("\t\t\t 2 - Verificar se você é maior de idade ");
            Console.WriteLine("\t\t\t 3 - Tabuada de um numero N ");
            Console.WriteLine("\t\t\t 4 - Leitura de arquivo C# ");
            Console.WriteLine("\t\t\t 0 - Sair do programa ");



        }
    }
}

