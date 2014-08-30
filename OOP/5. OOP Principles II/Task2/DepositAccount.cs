using System;

namespace BankSystem
{
    class DepositAccount : Account
    {
        public DepositAccount(CustomerType customer, decimal balance, decimal iRate)
            : base(customer, balance, iRate)
        { }

        public override decimal CalculateInterestRate(int months)
        {
            decimal currentRate = this.interestRate;
            if (this.balance < 1000)
            {
                currentRate = 0;
            }
            else
            {
                currentRate = base.CalculateInterestRate(months);
            }
            return currentRate;
        }

        public override void Withdraw(decimal amount)
        {
            this.balance = this.balance - amount;
        }
    }
}
