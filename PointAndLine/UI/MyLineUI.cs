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
    class MyLineUI
    {
        static public void showBegin()
        {
            Console.WriteLine("X coordinate is = " + Program.line.getBegin().getX());
            Console.WriteLine("Y coordinate is = " + Program.line.getBegin().getY());
        }

        static public void showEnd()
        {
            Console.WriteLine("X coordinate is = " + Program.line.getEnd().getX());
            Console.WriteLine("Y coordinate is = " + Program.line.getEnd().getY());
        }
    }
}
