using System;

namespace ResourceApp
{
    public abstract class Mine
    {
        protected readonly ResourcesStorage resourceStorage;

        public Mine(ResourcesStorage resourceStorage)
        {
            this.resourceStorage = resourceStorage;
        }

        public abstract void ProduceResources();
    }

    public class CoalMine : Mine
    {
        public CoalMine(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceResources()
        {
            resourceStorage.AddCoal(40);
        }
    }

    public class UraniumMine : Mine
    {
        public UraniumMine(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceResources()
        {
            resourceStorage.AddUranium(100);
        }
    }

    public class MoonMine : Mine
    {
        public MoonMine(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceResources()
        {
            resourceStorage.AddHelium(10);
        }
    }

    public class HadronCollider : Mine
    {
        public HadronCollider(ResourcesStorage resourceStorage) : base(resourceStorage) { }

        public override void ProduceResources()
        {
            resourceStorage.AddAntimatter(1);
        }
    }
}