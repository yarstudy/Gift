using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public class Gift
    {
        private List<AbstractCandy> items; //This field contains candies
        public string GiftName { get; private set; } //Name of gift

        //Gift Constructor
        public Gift(string giftName)
        {
            items = new List<AbstractCandy>();
            GiftName = giftName;
        }

        //This method adds candy as a gift
        public void Add(AbstractCandy candy)
        {
            items.Add(candy);
        }

        //This method presents gift
        public void ShowGift()
        {
            Console.WriteLine("This gift {0} contains the following candies:\n", GiftName);
            foreach (AbstractCandy candy in items)
            {
                candy.CandyInfo();
            }
        }

        //This method calculates the total weight of the gift
        public void GiftWeight(Gift gift)
        {
            int sum = 0;
            foreach (AbstractCandy candy in gift.items)
            { sum += candy.CandyWeight; }
            Console.WriteLine("Total weight of the gift: {0} gram", sum);
        }

        //This method sorts the gift by weight, without destroying  its structure
        public void SortByWeight()
        {
            Console.WriteLine("Candies from {0} are ordered in accordance with the weight:\n", GiftName);
            //return items.OrderBy(x => x.CandyWeight).ToList(); //to return new List
            items.OrderBy(x => x.CandyWeight).ToList().ForEach((candy) => candy.CandyInfo());
        }

        //This method chooses candies for sugar content
        public void ChooseCandiesBySugarContent(int min, int max)
        {
            List<AbstractCandy> tempCandies = new List<AbstractCandy>();
            foreach (AbstractCandy candy in items)
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

