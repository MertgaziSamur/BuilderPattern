using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Computer
    {
        Display display;
        GraphicCard graphicCard;
        Ram ram;
        HardDrive hardDrive;
        Keyboard keyboard;
        Cpu cpu;
        Mouse mouse;

        public Computer()
        {
            Console.WriteLine("Computer started!");
        }

        public void setDisplay(Display display)
        {
            this.display = display;
        }
        public void setGraphicCard(GraphicCard graphicCard)
        {
            this.graphicCard = graphicCard;
        }
        public void setRam(Ram ram)
        {
            this.ram = ram;
        }
        public void setHardDrive(HardDrive hardDrive)
        {
            this.hardDrive = hardDrive;
        }
        public void setKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }
        public void setCpu(Cpu cpu)
        {
            this.cpu = cpu;
        }
        public void setMouse(Mouse mouse)
        {
            this.mouse = mouse;
        }

        public Mouse getMouse()
        {
            return mouse;
        }
        public Cpu getCpu()
        {
            return cpu;
        }
        public Keyboard getKeyboard()
        {
            return keyboard;
        }
        public HardDrive getHardDrive()
        {
            return hardDrive;
        }
        public Ram getRam()
        {
            return ram;
        }
        public GraphicCard getGraphicCard()
        {
            return graphicCard;
        }
        public Display getDisplay()
        {
            return display;
        }

    }
}
