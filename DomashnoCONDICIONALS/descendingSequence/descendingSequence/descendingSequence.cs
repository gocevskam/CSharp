using System;

class descendingSequence
{
    static void Main()
    {
        Console.Write("enter a real number:n=");
        double n = double.Parse(Console.ReadLine());
        Console.Write("enter a real number:m=");
        double m = double.Parse(Console.ReadLine());
        Console.Write("enter a real number:s=");
        double s = double.Parse(Console.ReadLine());
        double biggestNumber = 0;
        double middleNumber = 0;
        double smallestNumber = 0;
        if ((n > m) && (n > s))
        {
            biggestNumber = n;
        }
        else
            if (m > s)
            {
                biggestNumber = m;
            }
            else
            {
                biggestNumber = s;
            }
        Console.WriteLine(biggestNumber);
        if (((n > m) && (n < s))||((n < m) && (n > s)))
            {
            middleNumber = n;
            }
            
        else if ((n > m) && (n > s))
        
             if (m < s)
             {
                middleNumber = s;
             }

             else
               {
                middleNumber = m;
               }  
        else
        {
            if (m < s)
                middleNumber = m;
            else
            {
                middleNumber = s;
            }
        }

        Console.WriteLine(middleNumber);

        if ((n < m) && (n < s))
        {
            smallestNumber = n;
        }
        else
            if (m > s)
            {
                smallestNumber = s;
            }
            else
            {
                smallestNumber = m;
            }
        Console.WriteLine(smallestNumber);

        Console.WriteLine("the descending sequence is:{0},{1},{2}.", biggestNumber, middleNumber, smallestNumber);

    }
}


