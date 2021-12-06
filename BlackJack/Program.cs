using System;

Cards card = new Cards();
bool hasMoney = true;
bool round = true;
bool roundAns = false;
card.newCard();

while (hasMoney)
{
    while (round)
    {
        while (!roundAns)
        {
            System.Console.WriteLine("What do you want to do \n1. Hit \n2. Stand");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    card.newCard();
                    break;
                case "2":
                    round = false;
                    break;
                default:
                    System.Console.WriteLine("Choose between 1 or 2");
                    answer = Console.ReadLine();
                    break;


            }
        }
    }
}


Console.ReadLine();
