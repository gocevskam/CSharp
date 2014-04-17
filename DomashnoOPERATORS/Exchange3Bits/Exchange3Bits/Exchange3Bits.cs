using System;

class Exchange3Bits
{
    static void Main()
    {

        Console.Write("Enter unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());

        uint firstMask = 1 << 3;
        uint nAndFirstMask = n & firstMask;
        uint bitThree = nAndFirstMask >> 3;

        uint secondMask = 1 << 4;
        uint nAndSecondMask = n & secondMask;
        uint bitFour = nAndSecondMask >> 4;

        uint thirdMask = 1 << 5;
        uint nAndThirdMask = n & thirdMask;
        uint bitFive = nAndThirdMask >> 5;

        uint fourthMask = 1 << 24;
        uint nAndFourthMask = n & fourthMask;
        uint bitTwentyFour = nAndFourthMask >> 24;

        uint fifthMask = 1 << 25;
        uint nAndFifthNask = n & fifthMask;
        uint bitTwentyFive = nAndFifthNask >> 25;

        uint sixthMask = 1 << 26;
        uint nAndSixthMask = n & sixthMask;
        uint bitTwentySix = nAndSixthMask >> 26;

        uint temp;    
        uint result;  

        if (bitThree == 0)
        {
            uint mask = ~((uint)(1 << 24)); 
            temp = n & mask;
        }
        else
        {
            uint mask = 1 << 24;   
            temp = n | mask;
        }
        result = temp;

        if (bitFour == 0)
        {
            uint mask = ~((uint)(1 << 25)); 
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 25;   
            temp = result | mask;
        }
        result = temp;

        if (bitFive == 0)
        {
            uint mask = ~((uint)(1 << 26));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 26;   
            temp = result | mask;
        }
        result = temp;

        if (bitTwentyFour == 0)
        {
            uint mask = ~((uint)(1 << 3));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 3;   
            temp = result | mask;
        }
        result = temp;

      
        if (bitTwentyFive == 0)
        {
            uint mask = ~((uint)(1 << 4));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 4;    
            temp = result | mask;
        }
        result = temp;

        
        if (bitTwentySix == 0)
        {
            uint mask = ~((uint)(1 << 5));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 5;  
            temp = result | mask;
        }
        result = temp;

        Console.WriteLine(" {0} is:  {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(result);
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
      
        
    }
}
