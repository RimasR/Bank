using System;
using Bank.Models;

namespace Bank.BankModel
{
    public class Client : Observer
    {
        public string Id;
        public string FullName;

        public void AttachSubject(Subject subject)
        {
            this.Subject = subject;
            subject.Attach(this);
        }

        public void AddTransaction(Transaction transaction)
        {
            Subject.SetState(transaction);
        }

        public override void Update()
        {
            var state = Subject.GetState();
            Console.WriteLine($"We've got a transaction: Credit Card {state.Id}, money sent: {state.Money}, by: {state.FullName}");
        }
    }
}