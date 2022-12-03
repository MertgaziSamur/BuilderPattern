using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ComputerBuilder : IComputerBuilder
    {
        private static ComputerBuilder builder = new ComputerBuilder();
        private Computer computer;

        public Computer buildComputer()
        {
            return computer;
        }

        public static ComputerBuilder GetBuilder()
        {
            return builder;
        }
        public IComputerBuilder buildCpu()
        {
            Cpu cpu = new Cpu();
            computer.setCpu(cpu);
            return builder;
        }

        public IComputerBuilder buildDisplay()
        {
            Display display = new Display();
            computer.setDisplay(display);
            return builder;
        }

        public IComputerBuilder buildGraphicCard()
        {
            GraphicCard graphicCard = new GraphicCard();
            computer.setGraphicCard(graphicCard);
            return builder;
        }

        public IComputerBuilder buildHardDrive()
        {
            HardDrive hardDrive = new HardDrive();
            computer.setHardDrive(hardDrive);
            return builder;
        }

        public IComputerBuilder buildKeyboard()
        {
            Keyboard keyboard = new Keyboard();
            computer.setKeyboard(keyboard);
            return builder;
        }

        public IComputerBuilder buildMouse()
        {
            Mouse mouse = new Mouse();
            computer.setMouse(mouse);
            return builder;
        }

        public IComputerBuilder buildRam()
        {
            Ram ram = new Ram();
            computer.setRam(ram);
            return builder;
        }
    }
}
