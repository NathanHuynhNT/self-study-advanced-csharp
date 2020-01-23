using System;

namespace DelegateDemo
{
    public delegate String OperationDelegate(string command);

    class ComputerSystem
    {
        public string StartApplication(string appName)
        {
            Console.WriteLine("Inside ComputerSystem::StartApplication()");
            return "Success!";
        }
        public string StopApplication(string appName)
        {
            Console.WriteLine("Inside ComputerSystem::StopApplication()");
            return "Success!";
        }
        public string InstallSoftware(string software)
        {
            Console.WriteLine("Inside ComputerSystem::InstallSoftware()");
            return "Success!";
        }
        public string UninstallSoftware(string software)
        {
            Console.WriteLine("Inside ComputerSystem::UninstallSoftware()");
            return "Success!";
        }
        public void Operation(string name, OperationDelegate oprDelegate)
        {
            Console.WriteLine("Result = {0}", oprDelegate(name));
        }
    }
    
}