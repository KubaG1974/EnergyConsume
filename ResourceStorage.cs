using System;

namespace ResourceApp
{
    public class ResourcesStorage
    {
        private static ResourcesStorage _instance;

        private ResourcesStorage()
        {
            Energy = 0;
            Coal = 0;
            Uranium = 0;
            Helium = 0;
            Antimatter = 0;
        }

        public static ResourcesStorage Instance => _instance;

        public int Energy { get; private set; }
        public int Coal { get; private set; }
        public int Uranium { get; private set; }
        public int Helium { get; private set; }
        public int Antimatter { get; private set; }

        public void AddEnergy(int amount)
        {
            Energy += amount;
        }

        public void AddCoal(int amount)
        {
            Coal += amount;
        }

        public void AddUranium(int amount)
        {
            Uranium += amount;
        }

        public void AddHelium(int amount)
        {
            Helium += amount;
        }

        public void AddAntimatter(int amount)
        {
            Antimatter += amount;
        }
    }
}