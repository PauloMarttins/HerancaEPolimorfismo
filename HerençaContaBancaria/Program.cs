using System;
using HerençaContaBancaria.Entities;
using System.Collections.Generic;
using System.Globalization;



namespace HerançaContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuperClasse generica.
            //Declaração da variavel list do tipo Account.
            //Instanciação do ArrayList.
           List<Account> list = new List<Account>();

            //Os parametros são respectivamente: Id, Nome, Saldo, taxa de juros mensal.
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));

            //Os parametros são respectivamente: Id, Nome, Saldo, Limite.
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));

            //Os parametros são respectivamente: Id, Nome, Saldo, taxa de juros mensal.
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));

            //Os parametros são respectivamente: Id, Nome, Saldo, Limite.
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            //Declaração da variavel sum que recebe o valor inicial de 0.0 (double).
            double sum = 0.0;

            //Para cada Conta acc na Lista, faça:
            foreach (Account acc in list)
            { 
                //Soma recebe soma mais saldo.
                sum += acc.Balance;
            }

            //O console irá escrever o valor total do saldo.
            //utiliza-se o ToString com o CultureInfo para que o valor apareça em formato moeda.
            Console.WriteLine("Total balance: " + sum.ToString("C2", CultureInfo.CurrentCulture));

            //Para cada conta acc no ArrayList, faça:
            foreach (Account acc in list)
            {
                //Conta acc recebe um saque de 10 reais.
                acc.Withdraw(10.0);
            }
            //Para cada conta acc no ArrayList, faça:
            foreach (Account acc in list)
            {
                //Console escreve O saldo atualizado da conta: numero da conta e o saldo da conta no formato moeda. (Concatenação)
                Console.WriteLine("Updated balance for account"
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("C2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}
