public class Train : TransportVehicle
{
    public int NumberOfWagons { get; set; }

    public Train(string name, int speed, int numberOfWagons) : base(name, speed)
    {
        NumberOfWagons = numberOfWagons;
    }

    public override int Capacity => NumberOfWagons * 100;

    public override void UpdateVehicle(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public override object Clone()
    {
        return new Train(Name, Speed, NumberOfWagons);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество вагонов: {NumberOfWagons}");
    }
}
