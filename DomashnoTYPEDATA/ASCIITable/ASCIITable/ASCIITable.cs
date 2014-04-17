using System;

    class ASCIITable
    {
        static void Main()
        {

            Console.OutputEncoding =System.Text.Encoding.Unicode;
            for (int i = 0; i < 128; i++)
            { 
                Console.WriteLine((char)i);
            }
        }
    }
