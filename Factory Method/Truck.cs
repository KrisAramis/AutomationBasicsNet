namespace Factory_Method
{
    public class Truck : IVehicle
    {
        // Классы, реализующие интерфейс IVehicle
        public void GetInfo()
        {
            Console.WriteLine("This is a Truck");
        }
    }
}