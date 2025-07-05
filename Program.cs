namespace Fawry
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            var cheese = new ShippableExpirableProduct("cheese",100,8,DateTime.Now.AddDays(30),400);
            var TV = new shippableProducts("TV", 50, 5,800);
            var Biscuits = new ShippableExpirableProduct("Biscuits", 150, 100, DateTime.Now.AddDays(10), 700);
            var scratchCard = new Products("Mobile Scratch Card", 50, 100);


            var customer = new Customer(5000, "Ahmed");
            var cart = new Cart();
            
            cart.Add(cheese, 2);
            cart.Add(TV, 3);
            cart.Add(scratchCard, 1);


         


           
            var shippingService = new ShippingService();
            shippingService.ShipProducts(cart.Iteams);


            cart.CheckOut(customer);

            Console.WriteLine($"\nCustomer {customer.name} new balance is: {customer.balance}");
        }
    }
}
