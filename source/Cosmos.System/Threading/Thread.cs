namespace Cosmos.System.Threading
{
    public delegate void ThreadStart();

    public class Thread
    {
        private ThreadStart entry;

        public Thread(ThreadStart entryPoint)
        {
            entry = entryPoint;
        }

        public void Start()
        {
            Cosmos.HAL.Global.CreateThread((uint)entry.GetHashCode());
        }
    }
}