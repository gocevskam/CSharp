using System;

    class NineHunderdNinetyNine
    {
        static void Main()
        {
            Console.WriteLine("Enter a number between[0...999]");
            int number = int.Parse(Console.ReadLine());
            string [] special ={"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven",
                             "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
                             "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
            string [] tens ={"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

            
            int firstDigit= number / 100;
            int secondDigit = number / 10;
            int secondDIgitHunderts= (number%100)/10;
            int secondDigit2 = number % 100;
            int thirdDigit = number % 10;

            if ((number>=0)&&(number<20))
            {
                Console.WriteLine(special[number]);
            }
            else if ((number>19)&&(number<100))
            {
                if(number%10==0)
            {
                Console.WriteLine(tens[secondDigit - 2]);
            }
                else
                    Console.WriteLine(tens[secondDigit -2]+" " + special[thirdDigit]);
            }
            else if ((number > 99) && (number < 1000))
            {
                if (secondDigit2 == 0)
                {
                    Console.WriteLine(special[firstDigit] + " Hunderd ");
                }
                else if (secondDigit2 > 0 && secondDigit2 < 20)
                {
                    Console.WriteLine(special[firstDigit]+ " Hunderd " + "and" + special[secondDigit2]);
                }
                else if (thirdDigit == 0)
                {
                    Console.WriteLine(special[firstDigit] + " Hunderd " + tens[secondDIgitHunderts -2]);
                }
                else
                {
                    Console.WriteLine(special[firstDigit]+ " Hunderd " + tens[secondDIgitHunderts - 2] + " " + special[thirdDigit]);
                }
            }
            
        }
    }

