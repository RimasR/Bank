using Bank.BankModel;
using Bank.Models;

namespace Bank.CommandControler
{
    public class CreateCreditCardCommand : ICommand
    {
        private CreditCard card;
        private AbstractCreditCardRepository cardRepo;
        private CreditCardAbstractFactory factory;
        private CardType type;

        public CreateCreditCardCommand(AbstractCreditCardRepository repository, CreditCardAbstractFactory factory, CardType type)
        {
            this.cardRepo = repository;
            this.factory = factory;
            this.type = type;
        }

        public void Execute()
        {
            card = factory.GetCreditCard(type);
            cardRepo.Add(card);
        }

        public void Undo()
        {
            cardRepo.Remove(card.GetCcNumber());
        }
    }
}