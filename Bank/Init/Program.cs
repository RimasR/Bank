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
            CreditCardFactory creditCardFactory = CreditCardFactory.GetCreditCardFactory(ClientType.Business);

            Client client = creditCardFactory.GetClient();
            CreditCard card = creditCardFactory.GetCreditCard(CardType.Gold);

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

            Console.WriteLine(client1);



        }
    }
}