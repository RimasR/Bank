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

        public override void Remove(string id)
        {
            Items.RemoveAll(x => x.GetCcNumber() == id);
        }
    }
}