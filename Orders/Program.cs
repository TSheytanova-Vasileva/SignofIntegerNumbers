string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

CalculateOrder(product, quantity);

static void CalculateOrder(string product, int quantity)
{
    if (product == "water")
    {
        double price = 1.00;
        double totleprice = quantity * price;
        Console.WriteLine($"{totleprice:f2}");

    }
    if (product == "coffee")
    {
        double price = 1.50;
        double totleprice = quantity * price;
        Console.WriteLine($"{totleprice:f2}");

    }
    if (product == "coke")
    {
        double price = 1.40;
        double totleprice = quantity * price;
        Console.WriteLine($"{totleprice:f2}");

    }
    if (product == "snacks")
    {
        double price = 2.00;
        double totleprice = quantity * price;
        Console.WriteLine($"{totleprice:f2}");

    }
}