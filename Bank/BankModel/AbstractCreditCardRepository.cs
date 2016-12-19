using System.Collections.Generic;

namespace Bank.BankModel
{
    public abstract class AbstractCreditCardRepository
    {
        public abstract void Add(object obj);

        public abstract CreditCard Get(string id);

        public abstract void Remove(string id);

        public abstract List<CreditCard> GetCreditCards();

        public abstract void ShowCards();
    }
}