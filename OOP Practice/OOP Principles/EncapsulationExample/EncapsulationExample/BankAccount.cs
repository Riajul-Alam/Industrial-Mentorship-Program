using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    public class BankAccount
    {
        private int _accountNumber;// field
        private decimal _balance;

        public BankAccount(int accountNumber, decimal balance)
        {
            _accountNumber = accountNumber;_balance = balance;
        }
        public int AccountNumber{get { return _accountNumber; }}//properties
        public decimal Balance
        {
            get { return _balance; }set { _balance = value; }
        }

        public void Deposit(decimal amount){_balance += amount;}//method

        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount){_balance -= amount;return true;}
            else{Console.WriteLine("Insufficient funds.");return false;}
        }
    }

}







