using System;
using System.Collections.Generic;

public abstract class TransportVehicle
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public TransportVehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    // Абстрактное свойство для вместимости
    public abstract int Capacity { get; }

    // Абстрактный метод для изменения значений свойств и полей
    public abstract void UpdateVehicle(int speed, string name);

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Транспортное средство: {Name}, Скорость: {Speed} км/ч, Вместимость: {Capacity}");
    }
}
