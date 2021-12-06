using System;
using System.Collections.Generic;

public class Cards
{
    Random generator = new Random();
    List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14 };
    List<string> shape = new List<string> { "Hearts", "Diamonds", "Clovers", "Spades" };

    public void newCard()
    {

        int whatNumber = generator.Next(0, 13);
        int whatShape = generator.Next(0, 3);

        System.Console.WriteLine(number[whatNumber] + " of " + shape[whatShape]);
    }
}
