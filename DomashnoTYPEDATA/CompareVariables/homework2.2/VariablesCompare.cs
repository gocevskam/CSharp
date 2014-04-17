using System;


class VariablesCompare
{
    static void Main()
        {
            Console.Write("Enter decimal number1:");
            decimal d1 =Convert.ToDecimal  (Console.ReadLine());

            Console.Write("Enter decimal number2:");
            decimal d2 = Convert.ToDecimal(Console.ReadLine());

            decimal d3 = 0.00000001M;
           

            if (((Math.Abs(d1-d2) < d3) || (Math.Abs(d2-d1) < d3)))
            {
                Console.WriteLine("true");

            }
            else
            {

                Console.WriteLine("false");
            }
            
           
            
        }
}

