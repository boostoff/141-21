using System; // Подключаем пространство имен System

// Базовый класс "Транспортное средство"
public class TransportVehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    // Конструктор по умолчанию
    public TransportVehicle()
    {
        Name = "Неизвестное транспортное средство";
        Speed = 0;
    }

    // Конструктор с параметром
    public TransportVehicle(string name)
    {
        Name = name;
        Speed = 0;
    }

    // Свойство, общее для всех производных классов
    public virtual int Capacity { get; set; }

    // Метод, который будет переопределен в производных классах
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Транспортное средство: {Name}, Скорость: {Speed} км/ч, Вместимость: {Capacity}");
    }
}

// Производный класс "Автомобиль"
public class Car : TransportVehicle
{
    public int NumberOfDoors { get; set; }

    public Car() : base("Неизвестный автомобиль")
    {
        NumberOfDoors = 4;
    }

    public Car(string name, int speed, int numberOfDoors) : base(name)
    {
        Speed = speed;
        NumberOfDoors = numberOfDoors;
    }

    public override int Capacity
    {
        get { return 5; }
        set { /* Можно оставить пустым, если не нужно */ }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество дверей: {NumberOfDoors}");
    }
}

// Производный класс "Поезд"
public class Train : TransportVehicle
{
    public int NumberOfWagons { get; set; }

    public Train() : base("Неизвестный поезд")
    {
        NumberOfWagons = 5;
    }

    public Train(string name, int speed, int numberOfWagons) : base(name)
    {
        Speed = speed;
        NumberOfWagons = numberOfWagons;
    }

    public override int Capacity
    {
        get { return NumberOfWagons * 100; }
        set { /* Можно оставить пустым, если не нужно */ }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество вагонов: {NumberOfWagons}");
    }
}

// Производный класс "Пароход"
public class Ship : TransportVehicle
{
    public int NumberOfCabins { get; set; }

    public Ship() : base("Неизвестный пароход")
    {
        NumberOfCabins = 10;
    }

    public Ship(string name, int speed, int numberOfCabins) : base(name)
    {
        Speed = speed;
        NumberOfCabins = numberOfCabins;
    }

    public override int Capacity
    {
        get { return NumberOfCabins * 4; }
        set { /* Можно оставить пустым, если не нужно */ }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество кают: {NumberOfCabins}");
    }
}

// Точка входа программы
class Program
{
    static void Main(string[] args)
    {
        TransportVehicle[] vehicles = new TransportVehicle[4];
        vehicles[0] = new Car("Toyota", 120, 4);
        vehicles[1] = new Train("Express", 80, 10);
        vehicles[2] = new Ship("Titanic", 30, 20);
        vehicles[3] = new Car("Honda", 130, 2);

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
