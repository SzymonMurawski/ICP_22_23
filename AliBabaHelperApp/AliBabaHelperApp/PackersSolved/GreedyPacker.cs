using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class GreedyPacker : IPacker
    {
        public Knapsack GetPackedKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack knapsack = new Knapsack(maxWeight, maxVolume);
            treasures.Sort((p, q) => { 
                if (p.Value > q.Value)
                {
                    return -1;
                } else if (p.Value < q.Value){
                    return 1;
                } else
                {
                    return 0;
                }
            });
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
