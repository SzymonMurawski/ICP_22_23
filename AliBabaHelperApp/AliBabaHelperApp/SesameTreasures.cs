using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AliBabaHelperApp
{
    public class SesameTreasures
    {
        private List<Treasure> Treasures;
        public SesameTreasures()
        {
            string jsonString = File.ReadAllText("SesameTreasures.json");
            Treasures = JsonSerializer.Deserialize<List<Treasure>>(jsonString)!;
        }
        public List<Treasure> GetAllTreasures()
        {
            // Return a copy of Treasures list
            return Treasures.Select(t => new Treasure(t)).ToList();
        }
    }
}
