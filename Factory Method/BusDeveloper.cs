namespace Factory_Method;

public class BusDeveloper : IDeveloper
{
    // Классы, реализующие интерфейс IDeveloper
    public IVehicle Create()
    {
        return new Bus();
    }
}