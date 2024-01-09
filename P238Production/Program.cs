using P238Production;

Console.WriteLine("System Id");
Product product1 = new("Iphone 15 Pro Max", 3500);

bool keeplooping = true;
while (keeplooping)
{
    Console.WriteLine("Press the button:");
    Console.WriteLine("1 - Create Product    \n" +
                      "2 - Show All Products\n" +
                      "0 - Exit\n");

    string? option = Console.ReadLine();
    int OptionNumber;
    bool isInt = int.TryParse(option, out OptionNumber);
    if (isInt)
    {
        if (OptionNumber >= 0 && OptionNumber <= 2)
        {
            switch (OptionNumber)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter product name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter product price:");
                    decimal Price = Convert.ToInt32(Console.ReadLine());
                    product1.Create(Name, Price);
                    Console.WriteLine("Product Created!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("All Products:");
                    product1.ShowAll();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    keeplooping = false;
                    break;
                    Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
