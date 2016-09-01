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
            Point p1 = new Snake.Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Snake.Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Snake.Point(2, 6, '%');
            p3.Draw();

            Point p4 = new Snake.Point(7, 4, '&');
            p4.Draw();

            List<Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            pointList.Add(p3);
            pointList.Add(p4);

            HorizontalLine hLine = new HorizontalLine(1, 7, 9, '&');
            hLine.Drow();
            VerticallLine vLine = new VerticallLine(10, 17, 9, 'x');
            vLine.Drow();

            Console.ReadLine();


        }


    }
}
