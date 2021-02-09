namespace BankAccount.Controllers
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class Account
    {
        internal static int Saldo { get; set; } = 1000;
        internal static int Credit { get; set; } = 5000;
        internal static int SwishLimit { get; set; } = 3000;
    }
    public class Bank
    {
        public void CreditChecker()
        {
            var excess = Account.Credit - 5000;
            Account.Credit = 5000;
            Account.Saldo += excess;
        }
        public void Output()
        {
            Debug.WriteLine("Saldo: " + Account.Saldo + "\nKredit: " + Account.Credit + "\nSwish: " + Account.SwishLimit);
        }
        public bool Deposit(int money)
        {
            if (money > 0)
            {
                if (Account.Credit < money)
                {
                    Account.Credit += money;
                    CreditChecker();
                }
                else if (Account.Credit > money)
                {
                    Account.Saldo += money;
                }
                return true;
            }
            else if (money > 15000)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool Withdraw(int money)
        {
            if (money > 0 && money < Account.Saldo && money < Account.Credit)
            {
                Account.Credit -= money;
                return true;
            }
            return false;
        }
        public bool CreditLimit(int money)
        {
            if (money < Account.Credit)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool Swish(int money)
        {
            if (money > 0 && money < Account.Saldo && money < Account.SwishLimit)
            {
                Account.Saldo -= money;
                Account.SwishLimit -= money;
                return true;
            }
            return false;
        }
        public bool Transfer(int money)
        {
            if (money < Account.Saldo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
