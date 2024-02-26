using System;
using HerençaContaBancaria.Entities;



namespace HerançaContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //amount = quantia.
            //override = sobrescrever.(ressignificar).
            //Balance = saldo.
            //Withdraw = sacar.
            //Loan = empréstimo.
            //Holder = titular.
            //Interest Rate = taxa de juros.

            //A seguir, utiliza-se a tecnica de polimorfismo para instaciar duas variaveis do mesmo tipo com objetos diferentes.
            // ou seja, Duas variaveis do tipo Account. porém.
            //Uma variavel recebe o objeto Account e a outra variavel recebe o objeto SavingAccount.

            //É importante que os argumentos que estao como parametro, estejam na ordem correta em relação aos argumentos da classe account.
            Account acc1 = new Account(1001, "Alex", 500.0);
           //Instanciação da variavel account do tipo (BusinessAccount) que recebe o Id, nome e saldo da conta, e limite de saque.
           //(Id, Titular, Saldo, taxa de Juros) 
           //Os parametros desse comando devem estar na ordem correta em relação as variaveis apresentadas como parametro no construtor
           // da classe SavingAccount.
            Account acc2 = new SavingsAccount(1002, "Bejnamin", 500.0, 0.01);

            //Os comandos para saque se comportam diferentes por conta da utilização do polimorfismo nos comandos à cima.
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            //UpCasting
            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            ////DownCasting (operação insegura)
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);

            ////Se esses comandos forem realizados fora do if, dará erro, pois o DownCasting é uma operação insegura.
            //if (acc3 is BusinessAccount)
            //{
            //    //Duas alternativas pra mesma função:
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    //BusinessAccount acc5 = acc3 as BusinessAccount;
            //    BusinessAccount acc5 = (BusinessAccount)acc3;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}
            
            ////Se esses comandos forem realizados fora do if, dará erro, pois o DownCasting é uma operação insegura.
            //if (acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = (SavingsAccount)acc3;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
        }
    }
}
