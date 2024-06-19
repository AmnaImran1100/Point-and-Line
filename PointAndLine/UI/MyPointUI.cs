using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.UI;
using PointAndLine;

namespace PointAndLine.UI
{
    class MyPointUI
    {
        static public void getInputFromConsole()
        {
            Console.WriteLine("Enter the x Coordinate of the starting point = ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y Coordinate of the starting point = ");
            int y1 = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint(x1, y1);
            Console.WriteLine("Enter the x Coordinate of the ending point = ");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y Coordinate of the ending point = ");
            int y2 = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint();
            end.setX(x2);
            end.setY(y2);
            Program.line.setBegin(begin);
            Program.line.setEnd(end);
        }

        static public void updateBegin()
        {
            Console.WriteLine("Enter the x Coordinate of the starting point = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y Coordinate of the starting point = ");
            int y = int.Parse(Console.ReadLine());
            MyPoint begin = new MyPoint();
            begin.setX(x);
            begin.setX(y);
            Program.line.setBegin(begin);
        }
        
        static public void updateEnd()
        {
            Console.WriteLine("Enter the x Coordinate of the starting point = ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y Coordinate of the starting point = ");
            int y = int.Parse(Console.ReadLine());
            MyPoint end = new MyPoint();
            end.setX(x);
            end.setX(y);
            Program.line.setEnd(end);
        }
    }
}
