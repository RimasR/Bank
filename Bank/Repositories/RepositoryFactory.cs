using Bank.BankModel;

namespace Bank.Repositories
{
    public class RepositoryFactory : AbstractRepositoryFactory
    {
        public override Repository GetClientRepository()
        {
            return new ClientRepository();
        }

        public override Repository GetCreditCardRepository()
        {
            return new CreditCardRepository();
        }
    }
}