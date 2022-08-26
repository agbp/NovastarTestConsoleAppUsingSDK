using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryDotNetFrameworkDll;
using Nova.Mars.SDK;

namespace NovastarTestConsoleAppUsingSDK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            calculation test = new calculation();
            int res = test.Add(2,5);

            Console.WriteLine("test, press any key to exit {0:G} ",res);

            MarsHardwareEnumerator _marsHWEnumerator = new MarsHardwareEnumerator();
            bool initRes = _marsHWEnumerator.Initialize();
            if (initRes)
            {
                Console.WriteLine("MarsHardwareEnumerator succesfully Initialized");
            }
            else {
                Console.WriteLine("MarsHardwareEnumerator NOT initialized");
                return;
            }

            Console.WriteLine("CtrlSystemCount = {0:G}", _marsHWEnumerator.CtrlSystemCount);
            Console.WriteLine("FuncCardInCommCount = {0:G}", _marsHWEnumerator.FuncCardInCommCount);

            MarsFunctionCardInCOM _marsFCInComm = new MarsFunctionCardInCOM(_marsHWEnumerator);

            bool unInitRes = _marsHWEnumerator.UnInitialize();
            if (initRes)
            {
                Console.WriteLine("MarsHardwareEnumerator succesfully UnInitialized");
            }
            else
            {
                Console.WriteLine("MarsHardwareEnumerator NOT Uninitialized");
                return;
            }

            Console.WriteLine(" last output, press any key to exit ");
            Console.ReadKey();
        }
    }
}
