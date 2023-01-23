using System.Text.Json.Serialization;

namespace AliBabaHelperApp
{
    public class Treasure
    {
        public string Name { get; set; }
        public int Value { get; private set; }
        public int Weight { get; private set; }
        public int Volume { get; private set; }
        [JsonConstructor]
        public Treasure(string Name, int Value, int Weight, int Volume) {
            this.Name = Name;
            this.Value = Value;
            this.Weight = Weight;
            this.Volume = Volume; 
        }
        // Copy constructor, used to make deep copies of SesameTreasures
        public Treasure(Treasure treasure)
        {
            Name = treasure.Name;
            Value = treasure.Value;
            Weight = treasure.Weight;
            Volume = treasure.Volume;
        }
    }
}
