using System;

namespace ResourceApp
{
    public abstract class EnergyConsumer
    {
        protected int energyConsumption;
        protected int accumulatedEnergy;

        public EnergyConsumer(int energyConsumption)
        {
            this.energyConsumption = energyConsumption;
            accumulatedEnergy = 0;
        }

        public bool ConsumeEnergy(int energyAmount)
        {
            if (accumulatedEnergy >= energyConsumption)
            {
                accumulatedEnergy -= energyConsumption;
                return true;
            }
            else
            {
                accumulatedEnergy += energyAmount;
                return false;
            }
        }
    }

    public class World : EnergyConsumer
    {
        public World() : base(6000000) { }
    }

    public class Poland : EnergyConsumer
    {
        public Poland() : base(40000) { }
    }

    public class NewYork : EnergyConsumer
    {
        public NewYork() : base(10000) { }
    }
}