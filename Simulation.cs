using System;
using System.Collections.Generic;

namespace ResourceApp
{
    public class Simulation
    {
        private ResourcesStorage resourceStorage;
        private List<PowerPlant> powerPlants;
        private List<Mine> mines;
        private List<EnergyConsumer> energyConsumers;

        public Simulation(ResourcesStorage resourceStorage, List<PowerPlant> powerPlants, List<Mine> mines, List<EnergyConsumer> energyConsumers)
        {
            this.resourceStorage = resourceStorage;
            this.powerPlants = powerPlants;
            this.mines = mines;
            this.energyConsumers = energyConsumers;
        }

        public void RunSimulation(int days)
        {
            for (int i = 0; i < days; i++)
            {
                foreach (var plant in powerPlants)
                {
                    plant.ProduceEnergy();
                }

                foreach (var mine in mines)
                {
                    mine.ProduceResources();
                }

                int totalEnergy = resourceStorage.Energy;
                foreach (var consumer in energyConsumers)
                {
                    if (consumer.ConsumeEnergy(totalEnergy))
                    {
                        break;
                    }
                }
            }
        }

        public bool IsSufficientForConsumer(EnergyConsumer consumer)
        {
            return consumer.ConsumeEnergy(resourceStorage.Energy);
        }
    }
}