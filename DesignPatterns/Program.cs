using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ins = new Bath();

            new Thread(ins.Use).Start();
            new Thread(ins.Flush).Start();

        }
    }

    class Bath
    {
        object locks = new Object();

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Use()
        {

            Console.WriteLine("Using Bath");
            Thread.Sleep(5000);
        }

        public void Flush()
        {

            Console.WriteLine("Flushing");
            Thread.Sleep(5000);
        }
    }
}
