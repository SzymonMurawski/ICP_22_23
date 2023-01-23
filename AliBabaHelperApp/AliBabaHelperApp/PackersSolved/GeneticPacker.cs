using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class GeneticPacker : IPacker
    {
        private readonly int PopulationSize = 10000;
        private readonly double MutationRate = 0.05;
        private readonly int Generations = 100;
        private Random random = new Random();
        public Knapsack GetPackedKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            List<Specimen> population = new List<Specimen>();
            // Initialize population randomly
            while (population.Count < PopulationSize)
            {
                population.Add(new Specimen(maxWeight, maxVolume, treasures));
            }
            // Evolve the population
            for (int i = 0; i < Generations; i++)
            {
                population = GetNextGeneration(population);
            }
            // Select best knapsack after population has evolved
            Knapsack bestKnapsack = population[0].Knapsack;
            foreach (Specimen specimen in population)
            {
                if (specimen.Knapsack.Value() > bestKnapsack.Value())
                {
                    bestKnapsack = specimen.Knapsack;
                }
            }
            return bestKnapsack;
        }

        private List<Specimen> GetNextGeneration(List<Specimen> currentPopulation)
        {
            List<Specimen> newGeneration = new List<Specimen>();
            while (newGeneration.Count < PopulationSize)
            {
                Specimen parent1 = Tournament(currentPopulation);
                Specimen parent2 = Tournament(currentPopulation);
                newGeneration.Add(parent1.ProduceOffspring(parent2, MutationRate));
                newGeneration.Add(parent2.ProduceOffspring(parent1, MutationRate));

            }
            return newGeneration;
        }

        private Specimen Tournament(List<Specimen> population)
        {
            Specimen a = population[random.Next(population.Count)];
            Specimen b = population[random.Next(population.Count)];
            return a.Fitness() > b.Fitness() ? a : b;
        }

        class Specimen
        {
            public readonly bool[] Genes;
            public readonly Knapsack Knapsack;
            public readonly List<Treasure> Treasures;
            Random random = new Random();

            public Specimen(int maxWeight, int maxVolume, List<Treasure> treasures)
            {
                Genes = new bool[treasures.Count];
                Knapsack = new Knapsack(maxWeight, maxVolume);
                Treasures = treasures;
                for (int i = 0; i < Genes.Length; i++)
                {
                    Genes[i] = random.Next() % 2 == 0;
                    if (Genes[i])
                    {
                        Knapsack.Add(treasures[i]);
                    }
                }
            }
            public Specimen(bool[] genes, Knapsack knapsack, List<Treasure> treasures)
            {
                Genes = genes;
                Knapsack = knapsack;
                Treasures = treasures;
            }

            public Specimen ProduceOffspring(Specimen secondParent, double mutationRate)
            {
                bool[] offspringGenes = new bool[Genes.Length];
                Knapsack offspringKnapsack = new Knapsack(Knapsack);
                for (int i = 0; i < Genes.Length; i++)
                {
                    offspringGenes[i] = i % 2 == 0 ? Genes[i] : secondParent.Genes[i];
                    if (random.NextDouble() < mutationRate)
                    {
                        offspringGenes[i] = !offspringGenes[i];
                    }
                    if (offspringGenes[i])
                    {
                        offspringKnapsack.Add(Treasures[i]);

                    }
                }
                return new Specimen(offspringGenes, offspringKnapsack, Treasures);
            }
            public int Fitness()
            {
                return Knapsack.Value();
            }
        }

    }
}
