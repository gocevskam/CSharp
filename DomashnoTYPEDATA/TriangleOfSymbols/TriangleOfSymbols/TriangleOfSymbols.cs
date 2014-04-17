using System;


    class TriangleOfSymbols
    {
        static void Main()
        {
            string s = "\u00a9";
            char a = Convert.ToChar(s);

            Console.WriteLine((" "+ " "+ " ") + a + (" " + " "+ " "));
            Console.WriteLine(" " + " " + a + " " + a + " " + " ");
            Console.WriteLine(" " + a + " "+ " " + " " + a + " ");
            Console.WriteLine((a + " " + a ) + " " + ( a + " " + a));
          
        }
    }

