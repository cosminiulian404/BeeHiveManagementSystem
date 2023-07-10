namespace BeeHiveManagementSystem
{
    abstract class Bee : IWorker
    {
        public abstract float CostPerShift { get; }
        public string Job { get; private set; }

        public Bee(string jobProperty)
        {
            Job = jobProperty;
        }

        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            { DoJob(); }
        }

        protected abstract void DoJob();
    }
}
