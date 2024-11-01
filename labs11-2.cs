public class Car : TransportVehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int speed, int numberOfDoors) : base(name, speed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override int Capacity => 5;

    public override void UpdateVehicle(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество дверей: {NumberOfDoors}");
    }
}
