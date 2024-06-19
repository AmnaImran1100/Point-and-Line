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
    class MyPoint
    {
        private int x;
        private int y;

        public MyPoint()
        {
            x = 0;
            y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public int getX()
        {
            return x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getY()
        {
            return y;
        }

        public double distanceWithCords(int x, int y)
        {
            double length = Math.Sqrt(Math.Pow((this.x - x), 2) + Math.Pow((this.y - y), 2));
            return length;
        }

        public double distanceWithObject(MyPoint another)
        {
            double length = Math.Sqrt(Math.Pow((x - another.x), 2) + Math.Pow((y - another.y), 2));
            return length;
        }

        public double distanceFromZero()
        {
            double length = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            return length;
        }

    }
}
