using Bank.BankModel;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Bank.Repositories
{
    public class ClientRepository : AbstractClientRepository
    {
        private List<Client> Items = new List<Client>();

        public override void Add(object obj)
        {
            Items.Add((Client)obj);
        }

        public override Client Get(string id)
        {
            return Items.FirstOrDefault(x => x.Id == id);
        }

        public override void Remove(string id)
        {
            Items.RemoveAll(x => x.Id == id);
        }

        public override void ShowClients()
        {
            foreach (var c in Items)
            {
                Console.WriteLine($"ClientRepo repo: ");
                Console.WriteLine($"Id:          {c.Id}");
                Console.WriteLine($"Full name:   {c.FullName}");
                Console.WriteLine($"Enrolled in: {c.GetType()}");
            }
            Console.WriteLine("----------------------------------");
        }
    }
}