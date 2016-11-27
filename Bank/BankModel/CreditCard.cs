using Bank.Models;

namespace Bank.BankModel
{
    public abstract class CreditCard : Subject
    {
        protected int CardNumberLength { get; set; }
        protected string CcNumber { get; set; }
        protected double Money { get; set; }

        public abstract double ShowMoney();

        public string GetCcNumber()
        {
            return CcNumber;
        }

        public void SetCcNumber(string number)
        {
            this.CcNumber = number;
        }
    }
}