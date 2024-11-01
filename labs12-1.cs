using System;
using System.Collections;
using System.Collections.Generic;

public abstract class TransportVehicle : ICloneable, IComparable<TransportVehicle>
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public TransportVehicle(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }

    public abstract int Capacity { get; }

    public abstract void UpdateVehicle(int speed, string name);

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Транспортное средство: {Name}, Скорость: {Speed} км/ч, Вместимость: {Capacity}");
    }

    // Метод для глубокого копирования
    public abstract object Clone();

    // Реализация IComparable для сортировки по скорости
    public int CompareTo(TransportVehicle other)
    {
        return Speed.CompareTo(other.Speed);
    }
}
