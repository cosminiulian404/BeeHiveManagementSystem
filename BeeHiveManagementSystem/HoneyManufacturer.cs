namespace BeeHiveManagementSystem
{
    class HoneyManufacturer : Bee
    {
        const float NECTAR_PROCESSED_PER_SHIFT = 33.15F;
        public override float CostPerShift { get { return 1.95f; } }

        public HoneyManufacturer() : base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
        }
    }
}
