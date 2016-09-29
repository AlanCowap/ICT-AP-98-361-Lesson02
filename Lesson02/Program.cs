using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{
    /**
 *  1.0 inital iteration of class
 *  1.1 modify to work with version 1.1 of Lesson02.Rectangle class
 *
 */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lesson02");
            //Create a Rectangle object, get it's area.
            Rectangle rect = new Rectangle();
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}
