﻿using System;

    class RandomValues
    {
        static void Main()
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomGenerator.Next(100, 200));
            }
           
        }
    }

