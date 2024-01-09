namespace P238Production;

public class Product
{
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public string Name { get; set; }
    public decimal Price { get; set; }
    public void Create(string Name, decimal Price)
    {
        Product product1 = new(Name, Price);
        Directory.CreateDirectory(@".\Production");
        if (!File.Exists(@".\Production\ProductList.txt"))
        {
            File.Create(@".\Production\ProductList.txt");
        }
        StreamWriter sw = new StreamWriter(@".\Production\ProductList.txt", true);
        sw.WriteLine($"Name: {product1.Name};  Price:{product1.Price};");
        sw.Close();
    }

    public void ShowAll()
    {
        StreamReader sr = new StreamReader(@".\Production\ProductList.txt");
        Console.WriteLine(sr.ReadToEnd());
    }
}
