using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaContaBancaria.Entities
{
    internal class Account
    {
        //A propriedade Number do tipo inteiro é o numero da conta.
        public int Number { get; private set; }

        //A propriedade Holder do tipo strind será o titular da conta.
        public string Holder { get; private set; }

        //A propriedade Balance do tipo double será o saldo da conta.
        public double Balance { get; protected set; }

        //Construtor vazío.
        public Account() 
        { 
        }

        //Através do Construtor Account, cada propriedade declarada anteriormente, receberá como valores, respectivamente, cada uma das variaveis
        //declaradas como referencia deste construtor.
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //este metodo void é responsavel por retirar de dentro da propriedade (Balance) o valor referente ao saque.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        //Este metodo void é responsavel por atribuir à propriedade (Balance) os valores de cada deposito.
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
