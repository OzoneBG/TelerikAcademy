using System;

namespace BankSystem
{
    class LoanAccount : Account
    {
        public LoanAccount(CustomerType customer, decimal balance, decimal iRate)
            : base(customer, balance, iRate)
        { }

        public override decimal CalculateInterestRate(int months)
        {
            decimal currentRate = this.interestRate;
            if (this.Customer == CustomerType.Individual)
            {
                if (months - 3 < 0)
                {
                    currentRate = 0;
                }
                else
                {
                    currentRate = base.CalculateInterestRate(months - 3);
                }
            }
            else if (this.customer == CustomerType.Company)
            {
                if (months - 2 < 0)
                {
                    currentRate = 0;
                }
                else
                {
                    currentRate = base.CalculateInterestRate(months - 2);
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
            throw new NotSupportedException("Loan accounts does not support withdraw operation.");
        }
    }
}
