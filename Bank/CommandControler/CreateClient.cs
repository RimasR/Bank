using System;
using Bank.BankModel;

namespace Bank.CommandControler
{
    public class CreateClient : ICommand
    {

        private Client client;
        private AbstractClientRepository clientRepo;
        private CreditCardAbstractFactory factory;
        
        public CreateClient(AbstractClientRepository clientRepo, CreditCardAbstractFactory factory)
        {
            this.clientRepo = clientRepo;
            this.factory = factory;
        }      

        public void Execute()
        {
            client = factory.GetClient();
            clientRepo.Add(client);
        }

        public void Undo()
        {
            clientRepo.Remove(client.Id);
        }
    }
}