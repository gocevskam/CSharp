using System;

    class StringToInt
    {
        static void Main()
        {
            string myString = "34 26 55 55 34";
            int sum = SumOfStrings(myString);

            Console.WriteLine(sum);
        }
            private static int SumOfStrings(string myString)
        {
            int sum;
            char[] charSeparators = new char[] { ' ' };
            string[] splittedArray = myString.Split(charSeparators,StringSplitOptions.RemoveEmptyEntries);
 
            sum = CompleteSum(splittedArray);
 
            return sum;
        }
 
        private static int CompleteSum(string[] splittedArray)
        {
            int total = 0;
            foreach (string number in splittedArray)
            {
                total += int.Parse(number);
            }
 
            return total;
        }
        }
    
