using System;

class CycleExersises
{
    static void Main()
    {
        Console.WriteLine("Enter a positve number < 100:");

        uint number = uint.Parse(Console.ReadLine());
        bool prime = true;
        for (uint devider = 2; devider <= 10; devider++)
        {
            if (number % devider == 0)
            {
                prime = false;
            }
            
        }
        Console.WriteLine("Is prime? {0}", prime);



    }
}
