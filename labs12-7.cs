class Program
{
    static void Main(string[] args)
    {
        TransportCompany company = new TransportCompany();

        // Добавляем транспортные средства
        company.AddVehicle(new Car("Toyota", 120, 4));
        company.AddVehicle(new Train("Express", 80, 10));
        company.AddVehicle(new Ship("Titanic", 30, 20));
        company.AddVehicle(new Car("Honda", 130, 2));

        Console.WriteLine("Список всех транспортных средств:");
        company.DisplayAllVehicles();

        // Сортировка по скорости
        Console.WriteLine("Сортировка по скорости:");
        var sortedBySpeed = new List<TransportVehicle>(company);
        sortedBySpeed.Sort(); // Использует IComparable
        foreach (var vehicle in sortedBySpeed)
        {
            vehicle.DisplayInfo();
        }

        // Сортировка по имени
        Console.WriteLine("Сортировка по имени:");
        var comparer = new VehicleComparer();
        var sortedByName = new List<TransportVehicle>(company);
        sortedByName.Sort(comparer); // Использует IComparer
        foreach (var vehicle in sortedByName)
        {
            vehicle.DisplayInfo();
        }

        // Демонстрация использования foreach
        Console.WriteLine("Использование foreach для вывода:");
        foreach (var vehicle in company)
        {
            vehicle.DisplayInfo();
        }

        // Демонстрация копирования
        var clonedCar = (Car)company[0].Clone(); // Клонирование первого автомобиля
        Console.WriteLine("Клонированный автомобиль:");
        clonedCar.DisplayInfo();
    }
}
