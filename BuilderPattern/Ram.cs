using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Ram
    {
        public void LoadOSKernelImage()
        {
            Console.WriteLine("Kernel Image loaded!");
        }
        public void LoadOS()
        {
            Console.WriteLine("OS kernel loaded!");
        }
        public void LoadDrivers()
        {
            Console.WriteLine("Drivers loaded!");
        }
        public void StartServices()
        {
            Console.WriteLine("Services started!");
        }
    }
}
