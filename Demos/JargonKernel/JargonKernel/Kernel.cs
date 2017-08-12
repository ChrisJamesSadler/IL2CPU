using System;
using Cosmos.System.Threading;
using Sys = Cosmos.System;

namespace JargonKernel
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Sys.Global.SchedulerEnabled = true;
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
            Thread t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
            t = new Thread(thread2);
            t.Start();
        }

        void thread2()
        {
            while(true)
            {
                Console.Write("HERE");
            }
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
