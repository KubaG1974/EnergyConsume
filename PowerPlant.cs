using System;

namespace ResourceApp
{
    public abstract class PowerPlant
    {
        protected ResourcesStorage resourceStorage;

        public PowerPlant(ResourcesStorage resourceStorage)
        {
            this.resourceStorage = resourceStorage;
        }

        public abstract void ProduceEnergy();
    }

    public class CoalPlant : PowerPlant
    {
        public CoalPlant(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceEnergy()
        {
            resourceStorage.AddEnergy(7);
            resourceStorage.AddCoal(-100);
        }
    }

    public class SolarPlant : PowerPlant
    {
        public SolarPlant(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceEnergy()
        {
            resourceStorage.AddEnergy(2);
        }
    }

    public class NuclearPlant : PowerPlant
    {
        public NuclearPlant(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceEnergy()
        {
            resourceStorage.AddEnergy(10000);
            resourceStorage.AddUranium(-1);
        }
    }

    public class FusionPlant : PowerPlant
    {
        public FusionPlant(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceEnergy()
        {
            resourceStorage.AddEnergy(20000);
            resourceStorage.AddHelium(-1);
        }
    }

    public class AnnihilationPlant : PowerPlant
    {
        public AnnihilationPlant(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceEnergy()
        {
            resourceStorage.AddEnergy(25000);
            resourceStorage.AddAntimatter(-1);
        }
    }
}
