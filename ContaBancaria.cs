using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class ContaBancaria
    {
        private int conta;
        public string nome;
        private double saldo;

        public void Imprime()
        {
            Console.WriteLine("Conta atualizada");
            Console.WriteLine("Conta: {0}, Titular: {1}, Saldo: {2}", this.conta, this.nome, this.saldo);
            Console.ReadLine();
        }

        public ContaBancaria(int conta, string nome, double saldo)
        {
            this.conta = conta;
            this.nome = nome;
            this.saldo = saldo;
        }

        public ContaBancaria(int conta, string nome)
        {
            this.conta = conta;
            this.nome = nome;
            saldo = 0;
        }

        public void Deposito(double dep)
        {
            this.saldo += dep; 
        }

        public void Saque(double dep)
        {
            this.saldo -= (dep+5);
        }
    }
}
