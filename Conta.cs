using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_individual_Tema_Exemplo_Heranca
{
    class Conta
    {
        // Declaração da variaveis com encapsulamento
        public int numero { get; private set; }
        public string titular { get; private set; }
        public double saldo { get; protected set; } //protected pra trocar o valor entra as classe  
        public Conta()
        {
            // Criação do construtor com parâmetros 
        }
        public Conta(int Numero, string Titular, double Saldo)
        {
            numero = Numero;
            titular = Titular;
            saldo = Saldo;
        }
        public virtual void Saque(double saldoTotal) //Faz o saque
        {
            saldo -= saldoTotal;
        }
        public void Deposito(double saldoTotal) //Faz o deposito
        {
            saldo += saldoTotal;
        }
    }
}