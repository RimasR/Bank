using System;
using Bank.BankModel;
using Bank.Models;

namespace Bank.CommandControler
{
    public class MakeTransaction : ICommand
    {
        private CreditCard creditCard;
        private Transaction transaction;

        public MakeTransaction(CreditCard creditCard, Transaction transaction)
        {
            this.creditCard = creditCard;
            this.transaction = transaction;
        }
        public void Execute()
        {
            creditCard.SetState(transaction);
        }

        public void Undo()
        {
            creditCard.RemoveTransaction(transaction);
        }
    }
}