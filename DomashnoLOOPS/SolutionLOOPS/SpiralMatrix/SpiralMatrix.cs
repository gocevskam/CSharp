using System;

class SpiralMatrix
{
    static void Main()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int[,] matrix = new int[number,number];
            int num = 1;
            int rowIndex = 0;
            int colIndex = 0;
            int maxRowIndex = number - 1;
            int maxColIndex = number - 1;
             do
        {
            for (int i = colIndex; i <=maxColIndex; i++)
            {
                matrix[rowIndex, i] = num;
                num++;            
            }
            rowIndex++;
            for (int i = rowIndex; i <= maxRowIndex; i++)
            {
                matrix[i, maxColIndex] = num;                             
                num++;
            }
            maxColIndex--;
            for (int i = maxColIndex; i >= colIndex; i--)
            {
                matrix[maxRowIndex, i] = num;                             
                num++;
            }
            maxRowIndex--;
            for (int i = maxRowIndex; i >= rowIndex; i--)
            {
                matrix[i, colIndex] = num;                                
                num++;
            }
            colIndex++;

        }
             while (num <= number * number);
             for (int rows = 0; rows < matrix.GetLength(0); rows++)
             {
                 for (int cols = 0; cols < matrix.GetLength(1); cols++)
                 {
                     Console.Write(matrix[rows, cols] + " ");
                 }
                 Console.WriteLine();
             }
    }
}

