using System.Collections.Generic;
using System.Linq;
using Bank.Models;

namespace Bank.BankModel
{
    public abstract class CreditCard : Subject
    {

        protected List<Transaction> TransactionHistory = new List<Transaction>();

        protected int CardNumberLength { get; set; }
        protected string CcNumber { get; set; }
        protected double Money { get; set; }

        public override void SetState(Transaction transaction)
        {
            TransactionHistory.Add(transaction);
            this.NotifyObservers();
        }

        public override Transaction GetState()
        {
            return TransactionHistory.Last();
        }

        public double ShowMoney()
        {
            return Money;
        }

        // TODO: DELETE CARD?

        public string GetCcNumber()
        {
            return CcNumber;
        }

        public void SetCcNumber(string number)
        {
            this.CcNumber = number;
        }
    }
}