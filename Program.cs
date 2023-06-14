using System;
using System.Collections.Generic;

namespace ResourceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ResourcesStorage resourceStorage = ResourcesStorage.Instance;

            // Configure power plants, mines, and energy consumers here
            List<PowerPlant> powerPlants = new List<PowerPlant>
            {
                new CoalPlant(resourceStorage),
                new SolarPlant(resourceStorage),
                new NuclearPlant(resourceStorage),
                new FusionPlant(resourceStorage),
                new AnnihilationPlant(resourceStorage)
            };

            List<Mine> mines = new List<Mine>
            {
                new CoalMine(resourceStorage),
                new UraniumMine(resourceStorage),
                new MoonMine(resourceStorage),
                new HadronCollider(resourceStorage)
            };

            List<EnergyConsumer> energyConsumers = new List<EnergyConsumer>
            {
                new World(),
                new Poland(),
                new NewYork()
            };

            Simulation simulation = new Simulation(resourceStorage, powerPlants, mines, energyConsumers);
            simulation.RunSimulation(30);

            Console.WriteLine(simulation.IsSufficientForConsumer(new NewYork()));
        }
    }
}