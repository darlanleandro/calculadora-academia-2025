using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(":::::::::::::::::::::::");
                Console.WriteLine("Calculadora teste 2025");
                Console.WriteLine(":::::::::::::::::::::::");

                Console.WriteLine("Escolha o que você deseja fazer");

                //v1.3 - calculadora app de soma e subtrair + loop break

                Console.WriteLine("1 = Somar");
                Console.WriteLine("2 = Subtrair");
                Console.WriteLine("3 = Multiplicar");
                Console.WriteLine("4 = Dividir");
                Console.WriteLine("5 = Tabuada");
                Console.WriteLine("S = Sair");
                string opcao = Console.ReadLine();

                if (opcao == "S")
                    break;

                else if (opcao == "5")
                { 
                Console.WriteLine(":::::::::::::::::::::::");
                Console.WriteLine("TABUADA");
                Console.WriteLine(":::::::::::::::::::::::");


                    Console.WriteLine("Digite o número desejado");
                        int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                        
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        int multiplicacao = numeroTabuada * contador;
                        string linhaDaTabuada = $"{numeroTabuada} x {contador} = {multiplicacao}";

                        Console.WriteLine(linhaDaTabuada);
                    }

                    Console.ReadLine();
                    continue;
                }   

                Console.Write("Digite agora o primeiro número: ");
                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Digite agora o segundo número: ");
                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0.0m;

                // estrutura de decisão
                if (opcao == "1")
                    resultado = primeiroNumero + segundoNumero;

                else if (opcao == "2")
                    resultado = primeiroNumero - segundoNumero;

                else if (opcao == "3")
                    resultado = primeiroNumero * segundoNumero;

                else if (opcao == "4")
                    while (segundoNumero == 0) 
                    {
                        Console.WriteLine("ERRO: NÃO É POSSÍVEL DIVIDIR POR ZERO! DIGITE O SEGUNDO NÚMERO NOVAMENTE");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                        continue;
                    }                                      
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }  

                Console.WriteLine("O resultado da sua operação é " + resultado);


                Console.ReadLine();
            }
            
        }
    }
}
