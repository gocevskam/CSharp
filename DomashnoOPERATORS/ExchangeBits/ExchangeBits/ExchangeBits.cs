using System;

    class ExchangeBits
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter any number of type \"uint\" to exchange bits {p,p+1,...,p+k-1}\n(counting of bits starting from 0) with bits {q,q+1,...,q+k-1}\nrespectively: ");
            uint input = uint.Parse(Console.ReadLine());
            Console.Write("p= ");
            byte positionP = byte.Parse(Console.ReadLine());
            Console.Write("q= ");
            byte positionQ = byte.Parse(Console.ReadLine());
            Console.Write("k= ");
            byte k = byte.Parse(Console.ReadLine());
            uint numberToAdd1 = ((input << (32 - positionQ - k)) >> (32 - k)) << positionP;
            uint numbertoAdd2 = ((input >> positionP) << (32 - k)) >> (32 - positionQ - k);
            uint numberToAdd = numberToAdd1 + numbertoAdd2;
            uint numberToSubtract1 = numberToAdd1 << (positionQ - positionP);
            uint numberToSubtract2 = numbertoAdd2 >> (positionQ - positionP);
            uint numberToSubtract = numberToSubtract1 + numberToSubtract2;
            uint output = (input - numberToSubtract) + numberToAdd;
            Console.WriteLine();
            Console.WriteLine("Result: " + output);
            Console.WriteLine();
        }
    }

