using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

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
                Console.WriteLine("6 = Histórico de Operações");
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

                else if (opcao == "6")
                {
                    Console.WriteLine(":::::::::::::::::::::::");
                    Console.WriteLine("HISTÓRICO DAS OPERAÇÕES!");
                    Console.WriteLine(":::::::::::::::::::::::");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");
                string strPrimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

                Console.Write("Digite o segundo número: ");
                string strSegundoNumero = Console.ReadLine();  

                decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

                decimal resultado = 0.0m;

                // estrutura de decisão
                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $" {primeiroNumero} + {segundoNumero} = {resultado}";
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $" {primeiroNumero} - {segundoNumero} = {resultado}";
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $" {primeiroNumero} * {segundoNumero} = {resultado}";
                }

                else if (opcao == "4")
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("ERRO: NÃO É POSSÍVEL DIVIDIR POR ZERO! DIGITE O SEGUNDO NÚMERO NOVAMENTE");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                        continue;
                    }
                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $" {primeiroNumero} / {segundoNumero} = {resultado}";
                }

                else
                    continue;

                contadorHistorico++;

                    Console.WriteLine("O resultado da sua operação é " + resultado);
                    
                Console.ReadLine();
            }
            
        }
    }
}
