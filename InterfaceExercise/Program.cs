namespace InterfaceExercise;

internal class Program
{
    static void Main(string[] args)
    {
        Phone phone1 = new Phone{ProductPrice = 800, ProductName = "IPhone 15", ProductColor = "Black"};
        Phone phone2 = new Phone{ProductPrice = 800, ProductName = "IPhone 12 Pro Max", ProductColor = "Pink"};

        Laptop laptop1 = new Laptop{ProductPrice = 1700, ProductName = "MacBook Pro", ProductSize = "13 in"};
        Laptop laptop2 = new Laptop{ProductPrice = 1200, ProductName = "Microsoft Surface Pro", ProductSize = "14 in"};

        Tablet tablet1 = new Tablet{ProductPrice = 800, ProductName = "IPad Air", ProductStorage = "500 GB"};
        Tablet tablet2 = new Tablet{ProductPrice = 1500, ProductName = "IPad Pro", ProductStorage = "2 TB"};

        List<IProduct> products = new List<IProduct>();
        products.AddRange(new IProduct[] {phone1, phone2, laptop1,laptop2, tablet1, tablet2});

        foreach(var product in products)
        {
            System.Console.WriteLine($"Product: {product.ProductName, -30}, Price: {product.ProductPrice:C}");
        }
    }
}

        /*List<IProduct> products = new List<IProduct> this is another way to add items to a list (not dyanmic)
        {
            new widget {ProductName = "Widget Silver", ProductPrice = 300},
            new widget {ProductName = "Widget Gold", ProductPrice = 550},
            new watch {ProductName = "Rolex", ProductPrice = 50000},
            new watch {ProductName = "TimeX", ProductPrice = 29}
        }*/