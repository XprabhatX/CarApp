// See https://aka.ms/new-console-template for more information
using CarApp;

public class Program()
{
    public static void Main(string[] args)
    {
        Console.WriteLine("car id:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("car brand:");
        string brand = Console.ReadLine();

        Console.WriteLine("car model:");
        string model = Console.ReadLine();

        Console.WriteLine("car price:");
        double price = double.Parse(Console.ReadLine());

        Car car = new Car
        {
            Id = id,
            Brand = brand,
            Model = model,
            Price = price
        };

        CarRepository repo = new CarRepository();

        if (repo.AddCar(car))
        {
            Console.WriteLine("Successfully added");
        }
        else
        {
            Console.WriteLine("Successfully added");
        }
    }
}