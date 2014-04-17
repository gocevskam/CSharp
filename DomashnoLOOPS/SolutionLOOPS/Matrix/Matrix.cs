using System;
class Matrix
{
    static void Main()
    {
        Console.Write("Enter a number < 20: N=");
        int number = int.Parse(Console.ReadLine());
      
        if (number < 20)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                for (int j = i; j < number + i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            }
        else
            Console.WriteLine("Invalid number");

        }
    }


