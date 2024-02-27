using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerençaContaBancaria.Entities
{
    //Aqui utilizamos um metodo de Herança chamado de Upcasting.
    //(SavingsAccount) é uma subclasse do tipo especializada da superclasse (Account)
    //Todas as informações contidas em (Account) agora tambem fazem parte de (SavingsAccount)
    //Ou seja, SavingAccount vai estender/ Herdar, tudo que há na classe Account.

    //Sealed significa Selado. Utiliza-se esse metodo para que não haja nenhuma outra subclasse de (SavingAccount)
    sealed class SavingsAccount : Account
    {
        //Declara-se a propriedade InterestRate do tipo double que representa a taxa de juros.
        public double InterestRate { get; set; }

        //Construtor vazio.
        public SavingsAccount() 
        { 
        }

        //Construtor com argumentos:
        // Para aproveitar os argumentos(Parametros de entrada) do construtor da classe account coloca-se : base (argumentos), após os argumentos(Parametros de entrada) do construtor local.
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            //Neste momento declara-se somente uma propriedade tendo em vista que todas as outras ja foram herdadas da classe account.
            InterestRate = interestRate;
            
        }

        //Este metodo atualiza o saldo da conta levando em consideração a taxa de juros do banco.
        //A taxa de juros nesse caso é 1% ou seja 0.01
        public void UpdateBalance()
        {
            //Saldo recebe saldo mais a porcentagem referente a taxa de juros que é (Saldo vezes a taxa)
            Balance += Balance * InterestRate;
        }

        //O modificador Override transcreve um novo sentido/ nova função para a palavra utilizada como metodo do construtor.
        // O que está entre chaves passa a ser a nova função para a palavra em amarelo (Método)
        //O uso do termo (sealed) Impossibilita que essa operação seja sobrescrita novamente.(O metodo está selado)
        public sealed override void Withdraw(double amount) 
        {
            //A palavra chave (base.) indica que o sistema deve buscar o lagoritmo do Withdraw que está localizado na classe Accoount.
            base.Withdraw(amount);
            //Saldo recebe salado menos quantia de saque.
            Balance -= 2.0;
        }
    }
}
