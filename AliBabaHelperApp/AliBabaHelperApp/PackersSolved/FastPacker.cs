using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class FastPacker : IPacker
    {
        public Knapsack GetPackedKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack knapsack = new Knapsack(maxWeight, maxVolume);
            foreach (var treasure in treasures)
            {
                if (knapsack.WillFit(treasure))
                {
                    knapsack.Add(treasure);
                }
            }
            return knapsack;
        }
    }
}
