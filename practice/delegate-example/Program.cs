using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerSystem comSysObj = new ComputerSystem();

            //Use of delegate
            OperationDelegate oprDelegate = new OperationDelegate(comSysObj.InstallSoftware);
            Console.WriteLine($"Result = {oprDelegate("MyApplication")}");
            oprDelegate = new OperationDelegate(comSysObj.StartApplication);
            Console.WriteLine($"Result = {oprDelegate("MyApplication")}");
            oprDelegate = new OperationDelegate(comSysObj.StopApplication);
            Console.WriteLine($"Result = {oprDelegate("MyApplication")}");
            oprDelegate = new OperationDelegate(comSysObj.UninstallSoftware);
            Console.WriteLine($"Result = {oprDelegate("MyApplication")}");

            //Passing delegate in method
            oprDelegate = new OperationDelegate(comSysObj.UninstallSoftware);
            comSysObj.Operation("MyApplication", oprDelegate);
        }
    }
}
