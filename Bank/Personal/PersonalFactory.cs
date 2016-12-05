using Bank.BankModel;
using Bank.Models;

namespace Bank.Personal
{
    public class PersonalFactory : CreditCardAbstractFactory
    {
        public override CreditCard GetCreditCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Gold:
                    return new PersonalGoldCreditCard();

                case CardType.Black:
                    return new PersonalBlackCreditCard();
            }

            return null;
        }

        public override Client GetClient()
        {
            return new PersonalClient();
        }
    }
}