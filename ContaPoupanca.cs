using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_individual_Tema_Exemplo_Heranca
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; } // declara as variáveis com encapsulamento
        public ContaPoupanca() //cria conta poupança
        {
            
        }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        public sealed override void Saque(double saldoTotal) // faz o Saque
        {
            base.Saque(saldoTotal);
            saldo -= 2.0;
        }
        public void atualizacaoSaldo() // atualiza o Saldo
        {
            saldo += saldo * TaxaJuros;

        }
    }
}