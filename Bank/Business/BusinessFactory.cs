using Bank.BankModel;
using Bank.Models;

namespace Bank.Business
{
    public class BusinessFactory : CreditCardAbstractFactory
    {
        public override CreditCard GetCreditCard(CardType cardType)
        {
            switch (cardType)
            {
                case CardType.Gold:
                    return new BusinessGoldCreditCard();

                case CardType.Black:
                    return new BusinessBlackCreditCard();
            }

            return null;
        }

        public override Client GetClient()
        {
            return new BusinessClient();
        }
    }
}