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

        int number = 42;
        float money = 99.99f;
        string text = "To jest przykładowy tekst";
        bool isLogged = true;
        char myChar = 'A';
        decimal price = 199.99m;

        Console.WriteLine("Liczba całkowita: " + number);
        Console.WriteLine("Liczba zmiennoprzecinkowa (float): " + money);
        Console.WriteLine("Tekst: " + text);
        Console.WriteLine("Wartość logiczna: " + isLogged);
        Console.WriteLine("Pojedynczy znak: " + myChar);
        Console.WriteLine("Liczba zmiennoprzecinkowa o największej precyzji (decimal): " + price);

        string myAge = "Age: ";
        int wifeAge = 18;
        string resultAge = myAge + wifeAge;
        Console.WriteLine(resultAge);
        // Wniosek: Operacja dodawania stringa i liczby powoduje konkatenację zamiast dodawania matematycznego.

        bool isTrue = true;
        bool isFalse = false;
        bool isReallyTrue = true;

        bool and = isTrue && isFalse;
        bool or = isTrue || isReallyTrue;
        bool negative = !isFalse;

        Console.WriteLine("AND: " + and);
        Console.WriteLine("OR: " + or);
        Console.WriteLine("NEGACJA: " + negative);

        int a = 5, b = 12;
        int add = a + b;
        int sub = a - b;
        int div = a / b;
        int mul = a * b;
        int mod = a % b;

        Console.WriteLine("Dodawanie: " + add);
        Console.WriteLine("Odejmowanie: " + sub);
        Console.WriteLine("Dzielenie: " + div);
        Console.WriteLine("Mnożenie: " + mul);
        Console.WriteLine("Modulo: " + mod);

        string x = "Ala ";
        string y = "ma ";
        string z = "kota.";
        string resultText = x + y + z;
        Console.WriteLine(resultText);
        // Spostrzeżenie: Konkatenacja stringów łączy je bez dodatkowych spacji, jeśli ich nie ma na końcu pierwszego elementu.
    }
}
