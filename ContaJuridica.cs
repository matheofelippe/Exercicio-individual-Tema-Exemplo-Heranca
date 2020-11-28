using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_individual_Tema_Exemplo_Heranca
{
    class ContaJuridica : Conta
    {
        public double EmprestimoLimite { get; set; } // Declaração das variáveis e uso do encapsulamento
        public ContaJuridica() //cria conta jurudica
        {

        }
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite) : base(numero, titular, saldo) // Cria o construtor com parâmetros utilizando o da classe Conta
        {
            EmprestimoLimite = emprestimoLimite;
        }
        public void Emprestimo(double saldoTotal) // faz o Empréstimo
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                saldo += saldoTotal;
            }
        }

    }
}