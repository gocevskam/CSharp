using System;

class ReversedDecimal
{
    static char[] ReverseDigits(decimal dec)
    {
        string stringDigits = Convert.ToString(dec);
        char[] reversedNumber = new char[stringDigits.Length];
        for (int i = 0, j = stringDigits.Length - 1; i < stringDigits.Length; j--, i++)
        {
            reversedNumber[j] = stringDigits[i];
        }
        return reversedNumber;
    }
    static void PrintArray(char[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
 

    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        decimal number = decimal.Parse(Console.ReadLine());
        string reversed = Convert.ToString(ReverseDigits(number));
        PrintArray(ReverseDigits(number));
    }
}
