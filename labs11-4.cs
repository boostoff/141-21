public class Ship : TransportVehicle
{
    public int NumberOfCabins { get; set; }

    public Ship(string name, int speed, int numberOfCabins) : base(name, speed)
    {
        NumberOfCabins = numberOfCabins;
    }

    public override int Capacity => NumberOfCabins * 4;

    public override void UpdateVehicle(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество кают: {NumberOfCabins}");
    }
}
