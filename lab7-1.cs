using System;
using System.IO;

class Автомобиль
{
    // Поля класса
    private string марка;
    private int мощность;
    private int стоимость;

    // Свойства для доступа к полям
    public string Марка
    {
        get { return марка; }
        set { марка = value; }
    }

    public int Мощность
    {
        get { return мощность; }
        set
        {
            if (value > 0)
                мощность = value;
            else
                throw new ArgumentException("Мощность должна быть больше 0.");
        }
    }

    public int Стоимость
    {
        get { return стоимость; }
        set
        {
            if (value > 0)
                стоимость = value;
            else
                throw new ArgumentException("Стоимость должна быть больше 0.");
        }
    }

    // Конструктор без параметров
    public Автомобиль()
    {
        марка = "Неизвестно";
        мощность = 100;
        стоимость = 10000;
    }

    // Конструктор с параметрами
    public Автомобиль(string марка, int мощность, int стоимость)
    {
        Марка = марка;
        Мощность = мощность;
        Стоимость = стоимость;
    }

    // Метод для вывода информации об автомобиле
    public void ПоказатьИнформацию()
    {
        Console.WriteLine($"Марка: {марка}, Мощность: {мощность} л.с., Стоимость: {стоимость} руб.");
    }

    // Метод для записи информации об автомобиле в файл
    public void СохранитьВФайл(string путь)
    {
        using (StreamWriter writer = new StreamWriter(путь, true))
        {
            writer.WriteLine($"Марка: {марка}, Мощность: {мощность} л.с., Стоимость: {стоимость} руб.");
        }
    }

    // Перегрузка оператора сложения (складываем мощности двух автомобилей)
    public static Автомобиль operator +(Автомобиль авто1, Автомобиль авто2)
    {
        return new Автомобиль
        {
            Марка = авто1.Марка + " & " + авто2.Марка,
            Мощность = авто1.Мощность + авто2.Мощность,
            Стоимость = авто1.Стоимость + авто2.Стоимость
        };
    }

    // Перегрузка операторов сравнения по стоимости
    public static bool operator >(Автомобиль авто1, Автомобиль авто2)
    {
        return авто1.Стоимость > авто2.Стоимость;
    }

    public static bool operator <(Автомобиль авто1, Автомобиль авто2)
    {
        return авто1.Стоимость < авто2.Стоимость;
    }
}

class Program
{
    static void Main()
    {
        // Создание объектов класса Автомобиль с использованием различных конструкторов
        Автомобиль авто1 = new Автомобиль("Audi", 150, 2000000);
        Автомобиль авто2 = new Автомобиль("BMW", 250, 3000000);

        // Демонстрация работы методов и свойств
        авто1.ПоказатьИнформацию();
        авто2.ПоказатьИнформацию();

        // Перегрузка оператора сложения
        Автомобиль авто3 = авто1 + авто2;
        Console.WriteLine("Результат сложения автомобилей:");
        авто3.ПоказатьИнформацию();

        // Сравнение автомобилей по стоимости
        if (авто1 > авто2)
            Console.WriteLine($"{авто1.Марка} дороже, чем {авто2.Марка}");
        else
            Console.WriteLine($"{авто2.Марка} дороже, чем {авто1.Марка}");

        // Сохранение данных об автомобилях в файл
        авто1.СохранитьВФайл("автомобили.txt");
        авто2.СохранитьВФайл("автомобили.txt");
    }
}
