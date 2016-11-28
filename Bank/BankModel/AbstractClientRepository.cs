namespace Bank.BankModel
{
    public abstract class AbstractClientRepository
    {
        public abstract void Add(object obj);

        public abstract Client Get(string id);

        public abstract void Remove(string id);
    }
}