using System;
using System.Globalization;
using Banco;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Conta conta;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
