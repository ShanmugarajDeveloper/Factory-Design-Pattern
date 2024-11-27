using System;
public interface IVehicle
{
    public void Drive();
}

public class Car:IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a Car");
    }
}

public class Bike:IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a Bike");
    }
}
public class VehicleFactory
{
    public static IVehicle getVehicleType(string vehicleType)
    {
        if (vehicleType == "Car")
        {
            return new Car();
        }
        else if (vehicleType == "Bike")
        {
           return new Bike();
        }
        return null;
    }
}

public class Client
{
    public IVehicle _vehicle;
    public Client(IVehicle vehicle)
    {
        _vehicle = vehicle;
    }
    public void DriveVehicle()
    {
        _vehicle.Drive();
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        IVehicle car = VehicleFactory.getVehicleType("Car");
        Client carClient = new Client(car);
        carClient.DriveVehicle(); // Output: Driving a Car

        IVehicle bike = VehicleFactory.getVehicleType("Bike");
        Client bikeClient = new Client(bike);
        bikeClient.DriveVehicle(); // Output: Riding a Bike
    }
}