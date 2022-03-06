using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Algorithm
{
    public class Items
    {
        public int value;
        public int weight;

        public Items(int value, int weight)
        {
            this.value = value;
            this.weight = weight;
        }
    }
    public class FractionalKnapsack
    {
        public  int comp(Items items1, Items items2)
        {
            // greedy about both value and weight so we need to take the proportion of them
            //means value or profit/weight.
            double r1 = items1.value / items2.weight;
            double r2 = items2.value / items2.weight;
            return r1 > r2 ? -1 : 0;
        }

        public  double fKnapsack(Items[] items, int weight)
        {

            double totalVal = 0f;
            int currentW = 0;
            Array.Sort(items,comp);

            foreach(Items item in items)
            {
                float remaining = weight - currentW;

                if(item.weight<=remaining)
                {
                    totalVal += (double)item.value;
                    currentW +=item.weight;
                }
                else
                {
                    if (remaining == 0)
                        break;

                    double fraction = remaining / (double)item.weight;
                    totalVal +=fraction*(double)item.value;
                    currentW += (int)(fraction*(double)item.weight);
                }
            }
            return totalVal;
        }

        public  void callKnapsack()
        {
            Items[] arr = { new Items(60, 10),
                   new Items(100, 20),
                   new Items(120, 30) };

            Console.WriteLine("Maximum value we can obtain = " +
                              fKnapsack(arr, 50));
        }
    }
    
}
