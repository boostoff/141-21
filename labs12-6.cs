public class TransportCompany : IEnumerable<TransportVehicle>
{
    private List<TransportVehicle> vehicles = new List<TransportVehicle>();

    public void AddVehicle(TransportVehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void RemoveVehicle(int index)
    {
        if (index >= 0 && index < vehicles.Count)
        {
            vehicles.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Некорректный индекс!");
        }
    }

    public void UpdateVehicle(int index, int speed, string name)
    {
        if (index >= 0 && index < vehicles.Count)
        {
            vehicles[index].UpdateVehicle(speed, name);
        }
        else
        {
            Console.WriteLine("Некорректный индекс!");
        }
    }

    public void DisplayAllVehicles()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }

    // Реализация интерфейса IEnumerable
    public IEnumerator<TransportVehicle> GetEnumerator()
    {
        return vehicles.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
