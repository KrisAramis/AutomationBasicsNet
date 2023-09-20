namespace Factory_Method;

public class BikeDeveloper : IDeveloper
{
    public IVehicle Create()
    {
        return new Bike();
    }
}