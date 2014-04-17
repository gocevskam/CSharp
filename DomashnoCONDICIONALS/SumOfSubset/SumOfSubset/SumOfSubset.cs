using System;

    class SumOfSubset
    {
        static void Main()
        {
            Console.Write("Enter an integer number a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number d=");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer number e=");
            int e = int.Parse(Console.ReadLine());
            if (((a + b)==0) || ((a+c)==0) || ((a+d==0) || ((a+e)==0)))
            {
                Console.WriteLine("Some subset is equal to zero");
            }
            if (((b + c) == 0) || ((b + d) == 0) || ((b + e) == 0))
            {
                Console.WriteLine("Some subset is equal to zero");
            }
            if (((c + d) == 0) || ((c + e) == 0))
            {
                Console.WriteLine("Some subset is equal to zero");
            }
            if ((d + e) == 0)
            {
                Console.WriteLine("Some subset is equal to zero");
            }
            if (((a+b+c)==0) || ((b+c+d)==0) || ((c+d+e)==0) || ((d+e+a)==0)|| ((e+d+b)==0))
            {
                Console.WriteLine("Some subset is equal to zero");
            }
            else
                Console.WriteLine("there isn't subset that is equal to zero");
        }
    }

