using System;

namespace BankSystem
{
    class MortgageAccount : Account
    {
        public MortgageAccount(CustomerType customer, decimal balance, decimal iRate)
            : base(customer, balance, iRate)
        { }

        public override decimal CalculateInterestRate(int months)
        {
            decimal currentRate = this.interestRate;
            if (this.customer == CustomerType.Individual)
            {
                if (months - 6 < 0)
                {
                    currentRate = 0;
                }
                else
                {
                    currentRate = base.CalculateInterestRate(months - 6);
                }
            }
            else if (this.customer == CustomerType.Company)
            {
                if (months > 12)
                {
                    decimal firstYearRate = base.CalculateInterestRate(12) / 2;
                    currentRate = firstYearRate + base.CalculateInterestRate(months - 12);
                }
                else
                {
                    currentRate = base.CalculateInterestRate(months) / 2;
                }
            }
            else
            {
                return 0;
            }
            return currentRate;
        }

        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException("Mortgage accounts does not support withdraw operation.");
        }
    }
}
