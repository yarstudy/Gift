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
        {
            Gift gift = new Gift("New Gift");
            gift.Add(new ChewyCandy("Meller", 90, 30, "Chocolate"));
            gift.Add(new Lollipop("Duchess", 40, 30));
            gift.Add(new ChocolateCandy("Cherry in cognac", 115, 105, "Cognac"));

            gift.ShowGift();
            Console.WriteLine();
            gift.GiftWeight(gift);
            Console.WriteLine();
            gift.SortByWeight();
            Console.WriteLine();
            gift.ChooseCandiesBySugarContent(25, 100);
            Console.ReadKey();
        }
    }
}