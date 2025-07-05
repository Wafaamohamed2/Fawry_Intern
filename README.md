# E-commerce OOP System

     This project is a simple console-based E-commerce system designed using Object-Oriented Programming (OOP) principles in C#.  
     It was built as part of a Fawry Quantum internship challenge to demonstrate a solid understanding of OOP concepts such as inheritance, interfaces, encapsulation, and polymorphism.

     
## Features
  **Product Catalog**  
   - Products have `name`, `price`, `quantity`.
   - Supports expirable products (e.g. cheese, biscuits) with `expirationDate`.
   - Supports shippable products with `weight` and shipping interface.


 **Shopping Cart**  
   - Add products with a specific quantity (only if stock available and not expired).
   - Calculates subtotal, shipping fee, and total amount.

 **Checkout System**  
   - Ensures:
     - Cart is not empty.
     - Products are not expired.
     - Customer has enough balance.
  - Deducts from customer balance.
  - Prints detailed receipt.

**Shipping Service**  
  - Gathers all shippable items from the cart.
  - Calculates total package weight in kg.
  - Prints shipment notice.


    
