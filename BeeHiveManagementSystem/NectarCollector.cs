namespace BeeHiveManagementSystem
{
    class NectarCollector : Bee
    {
        const float NECTAR_COLECTED_PER_SHIFT = 33.25F;
      
        public override float CostPerShift { get { return 1.95f; } }

        public NectarCollector() : base("Nectar Collector") { }

        protected override void DoJob()
        {
            HoneyVault.CollectNectar(NECTAR_COLECTED_PER_SHIFT);
        }

    }
}
