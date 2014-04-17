using System;

    class CardsPrint
    {
        static void Main()
        {
            string[] cards = {"Ace", "Duace", "three", "four", "five","six","seven","eight","nine","ten","Jack","Queen", "King"};
            string[] colors = {"clubs","diamonds", "hearts", "spades" };
            for (int i = 0; i < cards.Length; i++)
            {

                for (int j = 0; j < colors.Length; j++)
                {
                    Console.WriteLine("{0} of {1}", cards[i], colors[j]);
                }
                
            }
            
        }
    }

