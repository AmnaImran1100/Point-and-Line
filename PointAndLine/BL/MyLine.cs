using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.UI;
using PointAndLine;

namespace PointAndLine.BL
{
    class MyLine
    {
        private MyPoint begin;
        private MyPoint end;

        public MyLine()
        {

        }

        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        public MyPoint getBegin()
        {
            return begin;
        }

        public void setEnd(MyPoint end)
        {
            this.end = end;
        }

        public MyPoint getEnd()
        {
            return end;
        }

        public double getLength()
        {
            double x = end.getX() - begin.getX();
            double y = end.getY() - begin.getY();
            double length = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return length;
        }

        public double getGradient()
        {
            double gradient = (end.getY() - begin.getY()) / (end.getX() - begin.getX());
            return gradient;
        }

    }
}
