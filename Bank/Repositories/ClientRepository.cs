using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Bank.BankModel;

namespace Bank.Repositories
{
    public class ClientRepository : Repository
    {
        public List<Client> Items { get; set; }
        public override void Add(object obj)
        {
            Items.Add((Client)obj);
        }

        public override object Get(string id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }

        public override void Remove(string id)
        {
            Items.RemoveAll(x => x.Id == id);
        }
    }
}