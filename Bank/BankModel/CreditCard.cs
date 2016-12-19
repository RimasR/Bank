using System;
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
        protected string FullName { get; set; }

        public override void SetState(Transaction transaction)
        {
            TransactionHistory.Add(transaction);
            this.NotifyObservers();
        }

        public override Transaction GetState()
        {
            return TransactionHistory.Last();
        }

        public void RemoveTransaction(Transaction transaction)
        {
            TransactionHistory.Remove(transaction);
        }

        public double ShowMoney()
        {
            return Money;
        }

        public void ShowTransactions()
        {
            foreach(var t in TransactionHistory)
            {
                Console.WriteLine($"{t.Id}, {t.FullName}, {t.Money}");
            }
        }
        public string GetName()
        {
            return FullName;
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