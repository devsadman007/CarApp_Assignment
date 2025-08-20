

namespace CarApp1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        //This is Drive method
        public void Drive(int kilometers)
        {
            Mileage= Mileage + kilometers;
            Console.WriteLine("Car " + Brand + " " + Model + " has driven " + kilometers + " km. " + "Total mileage: " + Mileage + " km.");
        }

        // This is ShowCarInfo method
        public void ShowCarInfo()
        {
            Console.WriteLine("Car Info:" + " Brand - " + Brand + "," + " Model - " + Model + "," + " Year - " + Year + "," + " Mileage - " + Mileage);
        }
    }
}
