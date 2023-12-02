using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class CreditCard
    {
        public string cardNumber;
        public decimal currentBalance;

        public void Deposit(decimal amount)
        {
            currentBalance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= currentBalance)
            {
                currentBalance -= amount;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для снятия суммы с счета");
            }
        }

        public void PrintCardInfo()
        {
            Console.WriteLine($"Номер счета: {cardNumber}, текущий баланс: {currentBalance}");
        }
    }
}
