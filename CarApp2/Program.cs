using CarApp1;
public class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();

        // Initialize the properties of car1
        car1.Brand = "Toyota";
        car1.Model = "Corolla";
        car1.Year = 2020;
      

        Car car2 = new Car();
        // Initialize the properties of car2
        car2.Brand = "Tesla";
        car2.Model = "Model 3";
        car2.Year = 2021;
       

        car1.Drive(50);
        car2.Drive(120);
        car1.Drive(30);
    }
}