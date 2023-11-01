using System;

public class Car
{
    private string color;
    private string type;
    private int year;

    public Car(string color, string type, int year)
    {
        this.color = color;
        this.type = type;
        this.year = year;
    }

    public void Start()
    {
        Console.WriteLine("Автомобиль заведен");
    }

    public void Stop()
    {
        Console.WriteLine("Автомобиль заглушен");
    }

    public void SetYear(int newYear)
    {
        year = newYear;
        Console.WriteLine($"Год выпуска автомобиля установлен на {newYear}");
    }

    public void SetType(string newType)
    {
        type = newType;
        Console.WriteLine($"Тип автомобиля установлен на {newType}");
    }

    public void SetColor(string newColor)
    {
        color = newColor;
        Console.WriteLine($"Цвет автомобиля установлен на {newColor}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("Красный", "Седан", 2020);

        myCar.Start(); // Вывод: "Автомобиль заведен"
        myCar.Stop(); // Вывод: "Автомобиль заглушен"

        myCar.SetYear(2022); // Вывод: "Год выпуска автомобиля установлен на 2022"
        myCar.SetType("Кроссовер"); // Вывод: "Тип автомобиля установлен на Кроссовер"
        myCar.SetColor("Синий"); // Вывод: "Цвет автомобиля установлен на Синий"
    }
}