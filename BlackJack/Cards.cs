using System;
using System.Collections.Generic;

public class Cards
{
    Random generator = new Random();
    List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
    List<string> shape = new List<string> { "Hearts", "Diamonds", "Clovers", "Spades" };
    int[,] usedCard = new int[4, 13];
    bool newCards = false;
    int newDecks = 0;

    public void newCard()
    {


        while (!newCards)
        {
            int whatNumber = generator.Next(0, 13);
            int whatShape = generator.Next(0, 4);
            if (usedCard[whatShape, whatNumber] == 0)
            {
                usedCard[whatShape, whatNumber] = 1;
                newCards = true;

                switch (whatNumber)
                {
                    case 10:
                        System.Console.WriteLine("Jack of " + shape[whatShape]);
                        break;
                    case 11:
                        System.Console.WriteLine("Queen of " + shape[whatShape]);
                        break;
                    case 12:
                        System.Console.WriteLine("King of " + shape[whatShape]);
                        break;
                    case 1:
                        System.Console.WriteLine("Ace of " + shape[whatShape]);
                        break;
                    default:
                        System.Console.WriteLine(number[whatNumber] + " of " + shape[whatShape]);
                        break;
                }


            }


        }
        for (int i = 0; i < usedCard.GetLength(0); i += 1)
        {

            for (int l = 0; l < usedCard.GetLength(1); l += 1)
            {
                Console.Write(usedCard[i, l] + " ");
            }
            Console.WriteLine("");
        }
        for (int i = 0; i < usedCard.GetLength(0); i += 1)
        {

            for (int l = 0; l < usedCard.GetLength(1); l += 1)
            {
                if (usedCard[i, l] == 1)
                {
                    newDecks++;
                }

            }

        }

        newCards = false;
        System.Console.WriteLine(newDecks);
        if (newDecks == 52)
        {
            newDeck();
        }
        newDecks = 0;

    }

    private void newDeck()
    {
        System.Console.WriteLine("Shuffling deck");
        for (int i = 0; i < usedCard.GetLength(0); i += 1)
        {

            for (int l = 0; l < usedCard.GetLength(1); l += 1)
            {
                usedCard[i, l] = 0;
            }
        }

    }
}




