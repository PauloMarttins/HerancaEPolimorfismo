using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaContaBancaria.Entities
{
    //A prióri realiza-se uma manobra de dados utilizando (Herança).
    // Através do comando ( : Account) - tudo que está contido na class Account passará a pertencer tambem à class BusinessAccount.
    internal class BusinessAccount : Account
    {
        //A propriedade LoanLimit do tipo double é declarada.
        public double LoanLimit { get; set; }

        //Construtor vazío.
        public BusinessAccount()
        {
        }

        //Este construtor tambem utiliza o metodo de Herança, através do comando ( :base() ).
        //utilizando as proriedades e as variaveis que ja foram declaradas e atribuídas anteriormente, proporcionando um sistema mais limpo.
        //Declara-se uma nova propriedade de nome LoanLimit que recebe uma nova variavel de nome loanLimit.
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        //Neste construtor de metodo void, realiza-se uma condição utilizando (if) e a propriedade Balance recebe o valor do saldo da conta
        //que será somado com a quantia informada, servindo como referencia para o emprestimo.
        //Loan é o método que representa o emprestimo.
        public void Loan(double amount)
        {
            //Cria-se uma condição:
            //Se a quantia for menor ou igual ao Limite, o saldo recebe Saldo mais quantia.
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }
    }
}