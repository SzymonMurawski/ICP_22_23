using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class BruteForcePacker : IPacker
    {
        public Knapsack GetPackedKnapsack(int MaxWeight, int MaxVolume, List<Treasure> treasures)
        {
            int maxTreasures = treasures.Count;
            string maxNumber = new string('1', treasures.Count);
            int maxPermutation = Convert.ToInt32(maxNumber, 2);
            Knapsack bestKnapsack = new Knapsack(MaxWeight, MaxVolume);
            for(int i = 0; i <= maxPermutation; i++)
            {
                string permutationString = Convert.ToString(i, 2).PadLeft(treasures.Count, '0');
                Knapsack contenderKnapsack = GetKnapsack(permutationString, MaxWeight, MaxVolume, treasures);
                if (contenderKnapsack.Value() > bestKnapsack.Value())
                {
                    bestKnapsack = contenderKnapsack;
                }
            }
            return bestKnapsack;
        }
        private Knapsack GetKnapsack(string permutationString, int MaxWeight, int MaxVolume, List<Treasure> treasures)
        {
            Knapsack knapsack = new Knapsack(MaxWeight, MaxVolume);
            for(int i = 0; i < permutationString.Length; i++)
            {
                if (permutationString[i] == '1')
                {
                    knapsack.Add(treasures[i]);
                }
            }
            return knapsack;
        }
    }
}
