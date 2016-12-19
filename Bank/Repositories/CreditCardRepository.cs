using System;
using System.Collections.Generic;
using System.Linq;
using Bank.BankModel;

namespace Bank.Repositories
{
    public class CreditCardRepository : AbstractCreditCardRepository
    {
        private List<CreditCard> Items = new List<CreditCard>();

        public override void Add(object obj)
        {
            Items.Add((CreditCard)obj);
        }

        public override CreditCard Get(string id)
        {
            return Items.FirstOrDefault(x => x.GetCcNumber() == id);
        }

        public override List<CreditCard> GetCreditCards()
        {
            return Items;
        }

        public override void Remove(string id)
        {
            Items.RemoveAll(x => x.GetCcNumber() == id);
        }

        public override void ShowCards()
        {
            foreach (var c in Items)
            {
                Console.WriteLine($"CreditCard repo: ");
                Console.WriteLine($"Number:    {c.GetCcNumber()}");
                Console.WriteLine($"Full name: {c.GetName()}");
                Console.WriteLine($"Money:     {c.ShowMoney()}");
            }
            Console.WriteLine("----------------------------------");
        }
    }
}