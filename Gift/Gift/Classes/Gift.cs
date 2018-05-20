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
        public string Name { get; private set; } //Name of gift

        //Gift Constructor
        public Gift(string name)
        {
            items = new List<AbstractCandy>();
            Name = name;
        }

        //This method adds candy as a gift
        public void Add(AbstractCandy candy)
        {
            items.Add(candy);
        }

        //This method presents gift
        public void ShowGift()
        {
            Console.WriteLine("This gift {0} contains the following candies:\n", Name);
            foreach (AbstractCandy candy in items)
            {
                candy.Info();
            }
        }

        //This method calculates the total weight of the gift
        public void GiftWeight(Gift gift)
        {
            int sum = 0;
            foreach (AbstractCandy candy in gift.items)
            { sum += candy.Weight; }
            Console.WriteLine("Total weight of the gift: {0} gram", sum);
        }

        //This method sorts the gift by weight, without destroying  its structure
        public void SortByWeight()
        {
            Console.WriteLine("Candies from {0} are ordered in accordance with the weight:\n", Name);
            //return items.OrderBy(x => x.CandyWeight).ToList(); //to return new List
            items.OrderBy(x => x.Weight).ToList().ForEach((candy) => candy.Info());
        }

        //This method chooses candies for sugar content
        public void ChooseCandiesBySugarContent(int min, int max)
        {
            List<AbstractCandy> tempCandies = new List<AbstractCandy>();
            foreach (AbstractCandy candy in items)
            {
                if ((candy.Sugar >= min) && (candy.Sugar <= max))
                    tempCandies.Add(candy);
            }
            Console.WriteLine("These candies contain a suitable amount of sugar:\n");
            foreach (AbstractCandy candy in tempCandies)
            {
                Console.WriteLine("Name of candy: {0}, Sugar: {1} gram\n", candy.Name, candy.Sugar);
            }
        }
    }
}

