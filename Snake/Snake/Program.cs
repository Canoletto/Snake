using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');
            p1.Draw();
            p2.Draw();
            
            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            VerticalLine vLine = new VerticalLine(7, 3, 11, '@');
            hLine.Drow();
            vLine.Drow();

            Console.ReadLine();      
        }
    }
}
