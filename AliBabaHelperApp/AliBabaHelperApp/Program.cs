using AliBabaHelperApp.Packers;

namespace AliBabaHelperApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SesameTreasures sesameTreasures = new SesameTreasures();
            int maxWeigth = 150;
            int maxVolume = 50;

            // Get all classes implementing IPacker interface
            Type interfaceType = typeof(IPacker);
            IEnumerable<Type> types =  AppDomain.CurrentDomain.GetAssemblies()
              .Select(assembly => assembly.GetTypes().Where(type => !type.IsInterface && interfaceType.IsAssignableFrom(type)))
              .SelectMany(implementation => implementation);
            
            foreach (Type type in types)
            {
                IPacker packer = (IPacker)Activator.CreateInstance(type)!;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Knapsack packedKnapsack = packer.GetPackedKnapsack(maxWeigth, maxVolume, sesameTreasures.GetAllTreasures());
                watch.Stop();
                Console.WriteLine($"{type.Name} packed a knapsack worth {packedKnapsack.Value()} in {watch.ElapsedMilliseconds}ms");
            }
        }
    }
}