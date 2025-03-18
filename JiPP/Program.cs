using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        int result = 5 + 9;
        Console.WriteLine("Wynik dodawania: " + result);

        int number = 37;
        float money = 99.99f;
        string text = "Przykładowy tekst pisany";
        bool isLogged = true;
        char myChar = 'A';
        decimal price = 199.99m;

        Console.WriteLine("Liczba całkowita: " + number);
        Console.WriteLine("Liczba zmiennoprzecinkowa (float): " + money);
        Console.WriteLine("Tekst: " + text);
        Console.WriteLine("Wartość logiczna: " + isLogged);
        Console.WriteLine("Pojedynczy znak: " + myChar);
        Console.WriteLine("Liczba zmiennoprzecinkowa o największej precyzji (decimal): " + price);
    }
}
