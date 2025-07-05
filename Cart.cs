using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry
{
    public class Cart
    {
        public List<CartIteam> Iteams { get; set; }
        public Cart()
        {
            Iteams = new List<CartIteam>();
        }
        public void Add(Products product, int quantity)
        {
            if (product is ExpirableProducts expirable && expirable.IsExpired())
            {
                Console.WriteLine($"!! Cannot add {product.productName} to cart because it is expired.\n");
                return;
            }

            if (product.quantity >= quantity) // check if the product has enough stock
            {

                Iteams.Add(new CartIteam(product, quantity));
                product.ReduceStock(quantity);
            }
            else
            {
                Console.WriteLine("!! Not enough stock for " + product.productName );
            }
        }

        public float Subtotal()
        {
            float total = 0;
            foreach (var item in Iteams)
            {
                total += item.GetTotalPrice(); // calculate the total price of the cart
            }
            return total;
        }

        public float Shipping()
        {
            foreach (var item in Iteams)
            {
                if (item.IsShippable())
                {
                    return 30;
                }
            }
            return 0;
        }

        public float Amount()
        {
            return Subtotal() + Shipping(); // calculate the total amount of the cart
        }

        public void CheckOut(Customer customer)
        {

            if (Iteams.Count == 0)
            {
                Console.WriteLine("Cart is empty");
                return;
            }

            foreach(var item in Iteams)
            {
                if(item.product is ExpirableProducts expirable && expirable.IsExpired())
                {
                    Console.WriteLine($"Product {item.product.productName} is expired and cannot be purchased.");
                    return;

                }
            }


            float totalAmount = Amount();
            customer.DeductBalance(totalAmount);



           

            Console.WriteLine("** Checkout receipt **");
            foreach (var item in Iteams)
            {
                Console.WriteLine($"{item.quantity}x  {item.product.productName}      {item.GetTotalPrice()}");
            }
            Console.WriteLine("\n-----------------------");
            Console.WriteLine($"Subtotal     :{Subtotal()}");
            Console.WriteLine($"Shipping     :{Shipping()}");
            Console.WriteLine($"Amount       :{Amount()}");
        }

    }
}
