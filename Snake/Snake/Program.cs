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
            HorizontalLine upLine = new HorizontalLine(0, Console.BufferWidth - 1, 0, 'x');
            HorizontalLine downLine = new HorizontalLine(0, Console.BufferWidth - 1, 24, 'x');
            VerticallLine leftLine = new VerticallLine(0, 24, 0, 'x');
            VerticallLine rightLine = new VerticallLine(0, 24, Console.BufferWidth - 1, 'x');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();


            Console.ReadLine();


        }


    }
}
