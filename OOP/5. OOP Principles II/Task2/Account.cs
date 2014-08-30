using System;

namespace BankSystem
{
    abstract class Account
    {
        public enum CustomerType { Individual, Company };

        protected CustomerType customer;
        protected decimal balance;
        protected decimal interestRate;

        public Account(CustomerType customer, decimal balance, decimal iRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = iRate;
        }

        public CustomerType Customer
        {
            get { return this.customer; }
        }

        public decimal Balance
        {
            get { return this.balance; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
        }

        public void Deposit(decimal amount)
        {
            this.balance = this.balance + amount;
        }

        public virtual decimal CalculateInterestRate(int months)
        {
            decimal result = this.interestRate * months;
            return result;
        }

        public abstract void Withdraw(decimal amount);
    }
}