using System;

namespace MulticastDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DataCenter dc = new DataCenter();

            Console.WriteLine("Starting Data Center...");
            dc.Start();

            Console.WriteLine("Stopping Data Center...");
            dc.Stop();
        }
    }
}
