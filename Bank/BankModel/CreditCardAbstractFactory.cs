using Bank.Business;
using Bank.Models;
using Bank.Personal;

namespace Bank.BankModel
{
    public abstract class CreditCardAbstractFactory
    {
        public static CreditCardAbstractFactory GetCreditCardFactory(ClientType clientType)
        {
            if (clientType == ClientType.Business)
            {
                return new BusinessFactory();
            }
            else
            {
                return new PersonalFactory();
            }
        }

        public abstract CreditCard GetCreditCard(CardType cardType);

        public abstract Client GetClient();
    }
}