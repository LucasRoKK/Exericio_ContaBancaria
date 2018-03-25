using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria banco;

            Console.WriteLine("----BANCO JURUPIRA-----");
            Console.WriteLine(" ");

            Console.Write("Digite o numero da conta: ");
            int conta;
            conta = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n)");
            char validacao = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if(validacao == 's')
            {
                Console.Write("Digite o valor do deposíto inicial: ");
                double valor;
                valor = double.Parse(Console.ReadLine());
                banco = new ContaBancaria(conta, nome, valor);
            }
            else
            {
                banco = new ContaBancaria(conta, nome);
            }

            Console.WriteLine();
            banco.Imprime();

            Console.Write("Digite um valor para deposito: ");
            double aux = double.Parse(Console.ReadLine());
            banco.Deposito(aux);
            banco.Imprime();

            Console.WriteLine("");

            Console.Write("Digite um valor para saque: ");
            aux = double.Parse(Console.ReadLine());
            banco.Saque(aux);
            banco.Imprime();

        }
    }
}
