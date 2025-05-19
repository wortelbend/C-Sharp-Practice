using System;

interface IPrice
{
    double GetPrice();
}

class Car : IPrice
{
    public double price { get; set; }
    public string Name { get; set; }

    public Car(string name, double price)
    {
        this.Name = name;
        this.price = price;
    }

    public double GetPrice()
    {
        return price;
    }

    public string GetName()
    {
        return Name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", 750000);
        Console.WriteLine("車名: " + myCar.GetName());
        Console.WriteLine("價格: " + myCar.GetPrice() + " 元");
    }
}
