using System;

class Detal
{
    public string Name { get; set; }

    public Detal(string name)
    {
        Name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Деталь: {Name}");
    }
}

class Mechanism : Detal
{
    public Mechanism(string name) : base(name) { }

    public void Work()
    {
        Console.WriteLine($"Механизм {Name} работает.");
    }
}

class Izdelie : Mechanism
{
    public Izdelie(string name) : base(name) { }

    public void Display()
    {
        Console.WriteLine($"Изделие {Name} выставлено.");
    }
}

class Uzel : Izdelie
{
    public Uzel(string name) : base(name) { }

    public void Connect()
    {
        Console.WriteLine($"Узел {Name} соединен.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Установка кодировки на UTF-8
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Detal detal = new Detal("Шестеренка");
        detal.ShowInfo();

        Mechanism mechanism = new Mechanism("Редуктор");
        mechanism.ShowInfo();
        mechanism.Work();

        Izdelie izdelie = new Izdelie("Мотор");
        izdelie.ShowInfo();
        izdelie.Display();

        Uzel uzel = new Uzel("Коробка передач");
        uzel.ShowInfo();
        uzel.Connect();
    }
}
