using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Account
    {
        private int money;

        public int Money { get => money; set => money = value; }

        public Account()
        {
        }

        public Account(int money)
        {
            this.money = money;
        }

        public string Withdraw(int amount)
        {
            if (amount > money)
            {
                return "The account balance is not enough to make the transaction";
            }
            money -= amount;
            return "Transaction OK";
        }
        public void Deposit(int amount)
        {
            money += amount;
            Console.WriteLine("Successful!");
        }
        public int Balance()
        {
            return money;
        }
    }
}
