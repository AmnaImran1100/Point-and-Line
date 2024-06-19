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
    class menuUI
    {
        static public int menu()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("                           POINT & LINE                          *");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("1. Make a Line");
            Console.WriteLine("2. Update the Begin Point");
            Console.WriteLine("3. Upadate the End Point");
            Console.WriteLine("4. Show the Begin Point");
            Console.WriteLine("5. Show the End Point");
            Console.WriteLine("6. Get Length of the Line");
            Console.WriteLine("7. Get the Gradient of the Line");
            Console.WriteLine("8. Find the distance of the begin point from zero coordinate");
            Console.WriteLine("9. Fine the distance of the end point from the zero coordinate");
            Console.WriteLine("10. Exit");
            Console.Write("Enter your Option =");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        static public void clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
