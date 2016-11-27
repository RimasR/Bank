using Bank.Business;
using Bank.Models;
using Bank.Personal;
using Bank.Repositories;

namespace Bank.BankModel
{
    public abstract class AbstractRepositoryFactory
    {
        public static AbstractRepositoryFactory GetRepositoryFactory()
        {
            return new RepositoryFactory();
        }

        public abstract Repository GetClientRepository();

        public abstract Repository GetCreditCardRepository();
    }
}