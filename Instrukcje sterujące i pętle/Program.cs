using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swoje imię:");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name);

        int n1 = 10, n2 = 20;
        if (n1 > n2)
        {
            Console.WriteLine("{0} jest większe od {1}", n1, n2);
        }
        else if (n1 < n2)
        {
            Console.WriteLine("{0} jest mniejsze od {1}", n1, n2);
        }
        else
        {
            Console.WriteLine("{0} jest równe {1}", n1, n2);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("C#");
        }

        int count = 0;
        while (count < 10)
        {
            Console.WriteLine("C#");
            count++;
        }

        int n = 10;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("{0} - Parzysta", i);
            }
            else
            {
                Console.WriteLine("{0} - Nieparzysta", i);
            }
        }

        int m = 5;
        for (int i = 1; i <= m; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}