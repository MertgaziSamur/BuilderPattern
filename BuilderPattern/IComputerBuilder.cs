using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IComputerBuilder
    {
        IComputerBuilder buildRam();
        IComputerBuilder buildCpu();
        IComputerBuilder buildHardDrive();
        IComputerBuilder buildGraphicCard();
        IComputerBuilder buildDisplay();
        IComputerBuilder buildMouse();
        IComputerBuilder buildKeyboard();
        Computer buildComputer();
    }
}
