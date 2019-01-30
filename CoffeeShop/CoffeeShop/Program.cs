using Store.Classes;
using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();

            Book cleanCoding = new Book(464, "Robert Martin", "07/17/2008", 36.13m, "Clean Code");
            Book passionateProgrammer = new Book(191, "Chad Fowler", "05/28/2009", 9.99m, "The Passionate Programmer");
            AudioBook mistborn = new AudioBook("Mistborn: The Final Empire", 44.99m, 1440, "Brandon Sanders", "Micael Kramer");
            Coffee smallCoffee = new Coffee("Small");
            

            cart.AddItemToCart(cleanCoding);
            cart.AddItemToCart(passionateProgrammer);
            cart.AddItemToCart(mistborn);
            cart.AddItemToCart(smallCoffee);

            decimal grandTotal = 0;

            foreach(var item in cart.ItemsInCart)
            {
                Console.WriteLine(item.CartDisplayInfo());
                grandTotal += item.Cost;
            }

            Console.WriteLine($"\nGrand Total: {grandTotal.ToString("C")}");

            Console.ReadKey();
        }
    }
}
