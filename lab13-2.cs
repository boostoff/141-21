using System;
using System.IO;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        // Создаем автомобиль
        Car car = new Car("Toyota", "A123BC", "Иванов Иван Иванович");

        // Создаем камеру
        Camera camera = new Camera(100); // Разрешенная скорость 100 км/ч
        camera.SpeedLimitExceeded += car.HandleSpeeding; // Подписка на событие превышения скорости

        // Запускаем камеру
        camera.StartMonitoring(car);
    }
}

// Класс автомобиля
public class Car
{
    public string Brand { get; set; }
    public string LicensePlate { get; set; }
    public string Owner { get; set; }

    public Car(string brand, string licensePlate, string owner)
    {
        Brand = brand;
        LicensePlate = licensePlate;
        Owner = owner;
    }

    // Метод обработки превышения скорости
    public void HandleSpeeding(object sender, SpeedEventArgs e)
    {
        Console.WriteLine($"Скорость автомобиля {Brand} с гос. знаком {LicensePlate} превышена! Скорость: {e.Speed} км/ч");
        TrafficPolice.IssueFine(this, e.Speed);
    }
}

// Класс камеры
public class Camera
{
    private Timer timer;
    public event EventHandler<SpeedEventArgs> SpeedLimitExceeded;
    private int speedLimit;

    public Camera(int speedLimit)
    {
        this.speedLimit = speedLimit;
        timer = new Timer(2000); // Каждые 2 секунды
        timer.Elapsed += CheckSpeed;
    }

    public void StartMonitoring(Car car)
    {
        timer.Start();
        // Имитация скорости автомобиля для демонстрации
        Random random = new Random();
        while (true)
        {
            int currentSpeed = random.Next(80, 150); // Генерация случайной скорости
            Console.WriteLine($"Текущая скорость автомобиля {car.Brand}: {currentSpeed} км/ч");
            if (currentSpeed > speedLimit)
            {
                SpeedLimitExceeded?.Invoke(this, new SpeedEventArgs(currentSpeed));
            }
            System.Threading.Thread.Sleep(2000); // Задержка перед следующей проверкой
        }
    }

    private void CheckSpeed(object sender, ElapsedEventArgs e)
    {
        // Проверка скорости (будет имитироваться в бесконечном цикле в StartMonitoring)
    }
}

// Класс ГИБДД
public static class TrafficPolice
{
    public static void IssueFine(Car car, int speed)
    {
        int fineAmount = CalculateFine(speed);
        string message = $"Выписан штраф владельцу {car.Owner} (марка: {car.Brand}, гос. знак: {car.LicensePlate}) за превышение скорости на {speed - 100} км/ч. Штраф: {fineAmount} руб.";

        Console.WriteLine(message);
        SaveFineToFile(message);
    }

    private static int CalculateFine(int speed)
    {
        // Пример расчета штрафа (в зависимости от превышенной скорости)
        int overSpeed = speed - 100;
        return overSpeed * 100; // 100 рублей за каждый км/ч свыше лимита
    }

    private static void SaveFineToFile(string message)
    {
        string filePath = "fines.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}

// Класс для передачи информации о скорости
public class SpeedEventArgs : EventArgs
{
    public int Speed { get; private set; }

    public SpeedEventArgs(int speed)
    {
        Speed = speed;
    }
}
