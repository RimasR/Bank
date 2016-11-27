using Bank.BankModel;

namespace Bank.Business
{
    public class BusinessBlackCreditCard : CreditCard
    {
        public override void SetState(string state)
        {
            throw new System.NotImplementedException();
        }

        public override string GetState()
        {
            throw new System.NotImplementedException();
        }

        public override double ShowMoney()
        {
            throw new System.NotImplementedException();
        }
    }
}