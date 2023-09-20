using Factory_Method;
// Создаем разработчиков

IDeveloper carDeveloper = new CarDeveloper();
IDeveloper bikeDeveloper = new BikeDeveloper();
IDeveloper busDeveloper = new BusDeveloper();
IDeveloper truckDeveloper = new TruckDeveloper();

// Создаем объекты транспорта с использованием метода Create()
IVehicle car = carDeveloper.Create();
IVehicle bike = bikeDeveloper.Create();
IVehicle bus = busDeveloper.Create();
bus.GetInfo();
IVehicle truck = truckDeveloper.Create();