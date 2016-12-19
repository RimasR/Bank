using Bank.Business;
using Bank.Models;
using Bank.Personal;

namespace Bank.BankModel
{
    public abstract class CreditCardAbstractFactory
    {
        public static CreditCardAbstractFactory GetCreditCardFactory(object type)
        {
            return (CreditCardAbstractFactory)type;
        }

        public abstract CreditCard GetCreditCard(CardType cardType);

        public abstract Client GetClient();
    }
}