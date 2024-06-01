using petshop;
using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = string.Empty;

        Console.WriteLine("Press 1 to add a product");

        Console.WriteLine("Press 8 to view all products");

        Console.WriteLine("type 'exit' to quit");

        var productLogic = new ProductLogic();

        userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")
        {

            if (userInput == "1")
            {

                Console.WriteLine("Enter Product Name");

                userInput = Console.ReadLine();



                if (userInput == "dog leash")
                {
                    var dogleash = new DogLeash();

                    dogleash.Name = userInput;

                    Console.WriteLine("Enter length");

                    dogleash.LengthInches = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter what material product is made of");

                    dogleash.Material = Console.ReadLine();

                    productLogic.AddProducts(dogleash);
                }

                if (userInput == "cat food")
                {
                    var catfood = new CatFood();

                    catfood.Name = userInput;

                    Console.WriteLine("Enter weight in pounds");

                    catfood.WeightPounds = double.Parse(Console.ReadLine());

                    Console.WriteLine("Is this kitten food? Y or N");

                    catfood.IsKittenFood = Console.ReadLine().ToLower() == "y";

                    productLogic.AddProducts(catfood);
                }

            }
            else if (userInput == "8")
            {
                var products = productLogic.GetAllProducts();

                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Name}");
                }

            }

            Console.WriteLine("Press 1 to add a product");

            Console.WriteLine("Press 8 to view all products");

            Console.WriteLine("type 'exit' to quit");

            userInput = Console.ReadLine();

        }
    }
}




