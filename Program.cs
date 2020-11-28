using System;

namespace Exercicio_individual_Tema_Exemplo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0); //Criação da conta jurudica         
            Conta acc1 = bacc; //Passa os valores de bacc para acc1
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00); //Criação da conta jurudica  
            // Conta para Conta Poupança
            Conta acc3 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);
            ContaJuridica acc4 = (ContaJuridica)acc2; 
            acc4.Emprestimo(100.0);
            if (acc3 is ContaJuridica) //Verifica conta jurudica ou poupança
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            if (acc3 is ContaPoupanca)
            {
                ContaPoupanca acc5 = (ContaPoupanca)acc3;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
            Console.ReadKey();
        }
    }
}
