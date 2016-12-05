using System;
using Bank.BankModel;
using Bank.Business;
using Bank.Models;
using Bank.Repositories;

namespace Bank.Init
{
    internal class Program
    {
        private static void Main()
        {

            //Business creation
            CreditCardAbstractFactory creditCardFactory = CreditCardAbstractFactory.GetCreditCardFactory(ClientType.Business);

            Client client = creditCardFactory.GetClient();
            CreditCard card = creditCardFactory.GetCreditCard(CardType.Black);

            client.Id = "1";

            card.SetCcNumber("abc123");

            Console.WriteLine(client.GetType());
            Console.WriteLine(card.GetType());

            AbstractRepositoryFactory repositoryFactory = AbstractRepositoryFactory.GetRepositoryFactory();

            var clientRepo = repositoryFactory.GetClientRepository();
            var creditCardRepo = repositoryFactory.GetCreditCardRepository();
            creditCardRepo.Add(card);
            clientRepo.Add(client);
            var client1 = clientRepo.Get(client.Id);
            client1.AttachSubject(card);

            var transaction = new Transaction()
            {
                FullName = "Rimantas Radziunas",
                Id = "123",
                Money = 123
            };

            card.SetState(transaction);

            Console.WriteLine(client1);



        }
    }
}