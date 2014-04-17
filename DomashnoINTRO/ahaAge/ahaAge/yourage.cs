using System;

class yourage
{
    static void Main()
    {
        Console.WriteLine("enter your age:");
        string age = Console.ReadLine();
        int value;
        if (int.TryParse(age, out value))
        {
            Console.WriteLine(value + 10);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

