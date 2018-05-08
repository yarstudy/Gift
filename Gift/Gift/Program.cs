using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {                                              //Create a gift
            Gift gift = new Gift("New Gift");
            gift.Add(new ChewyCandy("Meller", 90, 30, "Chocolate"));
            gift.Add(new Lollipop("Duchess", 40, 30));
            gift.Add(new ChocolateCandy("Cherry in cognac", 115, 105, "Cognac"));

            gift.ShowGift();                           //Show the structure of a gift
            Console.WriteLine("======================");
            gift.GiftWeight(gift);                     //Show the structure of a gift
            Console.WriteLine("======================");
            gift.SortByWeight();                       //Sort the gift by weight
            Console.WriteLine("======================");
            gift.ChooseCandiesBySugarContent(25, 100); //Choose candy with a certain sugar content
            Console.WriteLine("======================");
            gift.ShowGift();                           //Once again show the structure of the gift
            Console.ReadKey();                         
        }
    }
}