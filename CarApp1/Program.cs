using CarApp1;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();
        // Initialize the properties of car1
        car1.Brand = "Toyota";
        car1.Model = "Corolla";
        car1.Year = 2020;
        car1.Mileage = 2000;

        Car car2 = new Car();
        // Initialize the properties of car2
        car2.Brand = "Tesla";
        car2.Model = "Model 3";
        car2.Year = 2021;
        car2.Mileage = 1500;

       car1.ShowCarInfo();
       car2.ShowCarInfo();
       

    }
}