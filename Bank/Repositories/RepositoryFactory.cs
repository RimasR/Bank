using Bank.BankModel;

namespace Bank.Repositories
{
    public class RepositoryFactory : AbstractRepositoryFactory
    {
        public override AbstractClientRepository GetClientRepository()
        {
            return new ClientRepository();
        }

        public override AbstractCreditCardRepository GetCreditCardRepository()
        {
            return new CreditCardRepository();
        }
    }
}