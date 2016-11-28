using Bank.Repositories;

namespace Bank.BankModel
{
    public abstract class AbstractRepositoryFactory
    {
        public static AbstractRepositoryFactory GetRepositoryFactory()
        {
            return new RepositoryFactory();
        }

        public abstract AbstractClientRepository GetClientRepository();

        public abstract AbstractCreditCardRepository GetCreditCardRepository();
    }
}