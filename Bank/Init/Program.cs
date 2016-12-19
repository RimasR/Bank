using System;
using Bank.BankModel;
using Bank.Business;
using Bank.CommandControler;
using Bank.Commands;
using Bank.Models;
using Bank.Repositories;

namespace Bank.Init
{
    internal class Program
    {
        private static void Main()
        {

            //Business creation
            CreditCardAbstractFactory creditCardFactory = CreditCardAbstractFactory.GetCreditCardFactory(new BusinessFactory());

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
            var transaction2 = new Transaction()
            {
                FullName = "Burrito Pakito",
                Id = "8620",
                Money = 1000
            };

            card.SetState(transaction);
            CommandProcessor commandProcessor = new CommandProcessor();
            var creditCommand = new CreateCreditCardCommand(creditCardRepo, creditCardFactory, CardType.Black);
            var creditCommand2 = new CreateCreditCardCommand(creditCardRepo, creditCardFactory, CardType.Gold);
            commandProcessor.ExecuteCommand(creditCommand);
            commandProcessor.ExecuteCommand(creditCommand2);
            creditCardRepo.ShowCards();


            clientRepo.ShowClients();
            var clientCommand = new CreateClient(clientRepo, creditCardFactory);
            commandProcessor.ExecuteCommand(clientCommand);
            clientRepo.ShowClients();

            var transactionCommand = new MakeTransaction(card, transaction2);
            commandProcessor.ExecuteCommand(transactionCommand);

            card.ShowTransactions();
            commandProcessor.UndoCommand();
            card.ShowTransactions();
        }
    }
}