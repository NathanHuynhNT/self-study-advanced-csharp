using System;

namespace MulticastDelegateDemo
{
    public delegate void OperationMulticastDelegate();
    class DataCenter
    {
        private Server server;
        private Printer printer;
        private CoolingSystem collingSystem;
        
        private OperationMulticastDelegate opr;

        public DataCenter()
        {
            server = new Server();
            printer = new Printer();
            collingSystem = new CoolingSystem();
        }

        public void Start()
        {
            opr = new OperationMulticastDelegate(server.Start);
            opr += new OperationMulticastDelegate(printer.Start);
            opr += new OperationMulticastDelegate(collingSystem.Start);

            opr();

            opr -= new OperationMulticastDelegate(server.Start);
            opr -= new OperationMulticastDelegate(printer.Start);
            opr -= new OperationMulticastDelegate(collingSystem.Start);
        }

        public void Stop()
        {
            opr = new OperationMulticastDelegate(server.Shutdown);
            opr += new OperationMulticastDelegate(printer.Stop);
            opr += new OperationMulticastDelegate(collingSystem.Stop);

            opr();

            opr -= new OperationMulticastDelegate(server.Shutdown);
            opr -= new OperationMulticastDelegate(printer.Stop);
            opr -= new OperationMulticastDelegate(collingSystem.Stop);
        }
    }

    class Server
    {
        public void Start()
        {
            Console.WriteLine("Inside Server::Start()");
        }
        public void Shutdown()
        {
            Console.WriteLine("Inside Server::Shutdown()");
        }
    }  

    class Printer
    {
        public void Start()
        {
            Console.WriteLine("Inside Printer::Start()");
        }
        public void Stop()
        {
            Console.WriteLine("Inside Printer::Stop()");
        }
    }  

    class CoolingSystem
    {
        public void Start()
        {
            Console.WriteLine("Inside CoolingSystem::Start()");
        }
        public void Stop()
        {
            Console.WriteLine("Inside CoolingSystem::Stop()");
        }
    }  
}