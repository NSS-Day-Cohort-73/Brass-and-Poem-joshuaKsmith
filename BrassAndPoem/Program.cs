
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Poetry Book 1",
        Price = 29.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trumpet",
        Price = 2499.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Euphonium",
        Price = 4999.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Tuba",
        Price = 24999.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Poetry Book 2",
        Price = 24.99M,
        ProductTypeId = 1
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Poetry Book",
        Id = 1
    },
    new ProductType()
    {
        Title = "Brass Instrument",
        Id = 2
    }
};

//put your greeting here
Console.Clear();
Console.WriteLine("Welcome to Brass & Poem!");

//implement your loop here
DisplayMenu();

void DisplayMenu()
{
    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine(@"-- Choose an option:
            1. Display all products
            2. Delete a product
            3. Add a new product
            4. Update product properties
            5. Exit"
        );

        choice = Console.ReadLine();
        Console.Clear();
        if (choice == "1")
        {
            DisplayAllProducts(products, productTypes);
        }
        else if (choice == "2")
        {
            DeleteProduct(products, productTypes);
        }
        else if (choice == "3")
        {
            AddProduct(products, productTypes);
        }
        else if (choice == "4")
        {
            UpdateProduct(products, productTypes);
        }
        else if (choice == "5")
        {
            Console.WriteLine("Goodbye!");
        }
        else 
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} -- {productTypes[products[i].ProductTypeId - 1].Title} -- {products[i].Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please select a product to delete:");
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} -- {productTypes[products[i].ProductTypeId - 1].Title} -- {products[i].Price}");
    }
    int delistChoice = int.Parse(Console.ReadLine().Trim()) - 1;
    products.RemoveAt(delistChoice);
    Console.Clear();
    Console.WriteLine($"Product deleted!");
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }