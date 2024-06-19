using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.UI;

namespace PointAndLine
{
    class Program
    {
        static public MyLine line = new MyLine();
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 10)
            {
                option = menuUI.menu();
                Console.ReadKey();
                Console.Clear();
                if (option == 1)
                {
                    MyPointUI.getInputFromConsole();
                    menuUI.clear();
                }
                else if (option == 2)
                {
                    MyPointUI.updateBegin();
                    menuUI.clear();
                }
                else if (option == 3)
                {
                    MyPointUI.updateEnd();
                    menuUI.clear();
                }
                else if (option == 4)
                {
                    MyLineUI.showBegin();
                    menuUI.clear();
                }
                else if (option == 5)
                {
                    MyLineUI.showEnd();
                    menuUI.clear();
                }
                else if (option == 6)
                {
                    Console.WriteLine("The Length of the Line is = " + line.getLength());
                    menuUI.clear();
                }
                else if (option == 7)
                {
                    Console.WriteLine("The Length of the Line is = " + line.getGradient());
                    menuUI.clear();
                }
                else if (option == 8)
                {
                    Console.WriteLine("The Distance of starting point from Origin = " + line.getBegin().distanceFromZero());
                    menuUI.clear();
                }
                else if (option == 9)
                {
                    Console.WriteLine("The Distance of starting point from Origin = " + line.getEnd().distanceFromZero());
                    menuUI.clear();
                }

            }
        }
    }
}
