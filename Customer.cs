using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class Customer
    {
        public float balance { get; private set; } 
        public string name { get; set; } 
        

        public Customer(float initialBalance , string name)
        {
            balance = initialBalance; // Initialize the customer's balance
            this.name = name;
        }

        public bool CanPay(float amount)
        {
            return balance >= amount; // Check if the customer has enough balance to pay
        }

        public void DeductBalance(float amount)
        {
            if (CanPay(amount))
            {
                balance -= amount; // Deduct the amount from the customer's balance
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance to complete The purchase."); 
            }
        }
    }
}
