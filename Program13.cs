﻿//**Static Members in a Banking System**

//Implement a `Bank` class with a static field `InterestRate` and a static method `SetInterestRate()`.
//Show how static members work across multiple objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Bank
    {
        public static double InterestRate { get; private set; }

        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public Bank(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public static void SetInterestRate(double newRate)
        {
            InterestRate = newRate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Bank.SetInterestRate(3.5);

    //        Bank account1 = new Bank("Alice", 1000);
    //        Bank account2 = new Bank("Bob", 2000);

    //        account1.DisplayAccountInfo();
    //        account2.DisplayAccountInfo();

    //        Bank.SetInterestRate(4.0);

    //        account1.DisplayAccountInfo();
    //        account2.DisplayAccountInfo();
    //    }
    //}
}