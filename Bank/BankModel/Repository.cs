using System.Collections.Generic;

namespace Bank.BankModel
{
    public abstract class Repository
    {
        public abstract void Add(object obj);

        public abstract object Get(string id);

        public abstract void Remove(string id);

    }
}