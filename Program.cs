using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();
            Point p2 = new Point(4, 5, '#');
            p2.Draw();*/

            /*HorizontalLine lineH = new HorizontalLine(5, 10, 7, '+'); ;
            lineH.Draw();

            VerticalLine lineV = new VerticalLine(5, 10, 7, '+'); ;
            lineV.Draw();*/


            HorizontalLine lineU = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine lineD = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lineL = new VerticalLine(0, 24, 0, '+');
            VerticalLine lineR = new VerticalLine(0, 24, 78, '+');
            lineU.Draw();
            lineD.Draw();
            lineL.Draw();
            lineR.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);


            Console.ReadKey();
        }
    }
}
