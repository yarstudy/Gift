using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class Gift
    {
        private ICollection<AbstractCandy> items;
        public string GiftName {get; private set;}
        public Gift(string giftName)
        {
            items = new List<AbstractCandy>();
            GiftName = giftName;
        }
        public IEnumerable<AbstractCandy> Items
        {
            get { return this.items; }
        }
        public void Add(AbstractCandy candies)
        {
            items.Add(candies);
        }
        public void ShowGift()
        {
            Console.WriteLine("This gift {0} contains the following candies:\n", GiftName);
            foreach (AbstractCandy candy in Items)
            {
                candy.CandyInfo();
            }
        }
        public void GiftWeight(Gift gift)
        {
            int sum = 0;
            foreach (AbstractCandy candy in gift.Items)
            { sum += candy.CandyWeight; }
            Console.WriteLine("Total weight of the gift: {0} gram", sum);
        }

        public void SortByWeight()
        {
            List<AbstractCandy> tempCandies = items.OrderBy(x => x.CandyWeight).ToList();
            items.Clear();
            foreach (AbstractCandy candy in tempCandies)
            {
                items.Add(candy);
            }
        }
        public void ChooseCandiesBySugarContent(int min, int max)
        {
            List<AbstractCandy> tempCandies = new List<AbstractCandy>();
            foreach (AbstractCandy candy in Items)
            {
                if ((candy.CandySugar >= min) && (candy.CandySugar <= max))
                    tempCandies.Add(candy);
            }
            Console.WriteLine("These candies contain a suitable amount of sugar:\n");
            foreach (AbstractCandy candy in tempCandies)
            {
                Console.WriteLine("Name of candy: {0}, Sugar: {1} gram\n", candy.CandyName, candy.CandySugar);
            }
        }


    }
}
