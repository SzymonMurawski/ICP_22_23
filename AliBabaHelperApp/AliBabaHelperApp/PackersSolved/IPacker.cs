namespace AliBabaHelperApp.Packers
{
    public interface IPacker
    {
        public Knapsack GetPackedKnapsack(int MaxWeight, int MaxVolume, List<Treasure> treasures);
    }
}
