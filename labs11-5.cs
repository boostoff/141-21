public class TransportCompany
{
    private List<TransportVehicle> vehicles = new List<TransportVehicle>();

    // Метод для добавления нового транспортного средства
    public void AddVehicle(TransportVehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    // Метод для удаления транспортного средства по индексу
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

    // Метод для изменения свойств транспортного средства
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

    // Метод для вывода информации о всех транспортных средствах
    public void DisplayAllVehicles()
    {
        for (int i = 0; i < vehicles.Count; i++)
        {
            Console.WriteLine($"Индекс: {i}");
            vehicles[i].DisplayInfo();
            Console.WriteLine();
        }
    }
}
