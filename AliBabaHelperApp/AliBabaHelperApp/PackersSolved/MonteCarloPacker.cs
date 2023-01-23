using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class MonteCarloPacker : IPacker
    {
        private readonly int Iterations = 10000;
        Random random = new Random();
        public Knapsack GetPackedKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack bestKnapsack = new Knapsack(maxWeight, maxVolume);
            for (int i = 0; i < Iterations; i++)
            {
                Knapsack contender = GetRandomlyFilledKnapsack(maxWeight, maxVolume, treasures);
                if (contender.Value() > bestKnapsack.Value())
                {
                    bestKnapsack = contender;
                }
            }
            return bestKnapsack;
        }
        private Knapsack GetRandomlyFilledKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack randomKnapsack = new Knapsack(maxWeight, maxVolume);
            foreach (var treasure in treasures)
            {
                if (random.Next() % 2 == 0)
                {
                    randomKnapsack.Add(treasure);
                }
            }
            return randomKnapsack;
        }
    }
}
