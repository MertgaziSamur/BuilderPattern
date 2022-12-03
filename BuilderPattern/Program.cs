using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerBuilder computerBuilder = new ComputerBuilder();
            computerBuilder.buildComputer();

        }
    }
}
