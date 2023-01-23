namespace AliBabaHelperApp
{
    public class Knapsack
    {
        private readonly int MaxWeight;
        private readonly int MaxVolume;
        private int CurrentWeight;
        private int CurrentVolume;
        private int TotalValue;
        private readonly List<Treasure> Items;
        public Knapsack(int maxWeight, int maxVolume)
        {
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            CurrentWeight = 0;
            CurrentVolume = 0;
            TotalValue = 0;
            Items = new List<Treasure>();
        }
        public Knapsack(Knapsack knapsack)
        {
            MaxWeight = knapsack.MaxWeight;
            MaxVolume = knapsack.MaxVolume;
            CurrentWeight = 0;
            CurrentVolume = 0;
            TotalValue = 0;
            Items = new List<Treasure>();
        }
        public void Add(Treasure treasure)
        {
            TotalValue += treasure.Value;
            CurrentWeight += treasure.Weight;
            CurrentVolume += treasure.Volume;
            Items.Add(treasure);
        }
        public bool WillFit(Treasure treasure)
        {
            return CurrentWeight + treasure.Weight <= MaxWeight 
                && CurrentVolume + treasure.Volume <= MaxVolume;
        }
        public int Value()
        {
            if(CurrentWeight > MaxWeight || CurrentVolume > MaxVolume)
            {
                return 0;
            }
            return TotalValue;
        }
    }
}
