namespace Factory_Method
{
// Интерфейс IVehicle
    public interface IVehicle
    {
        //  Продукт определяет общий интерфейс объектов, которые может произвести создатель и его подклассы.
        void GetInfo();
    }
}