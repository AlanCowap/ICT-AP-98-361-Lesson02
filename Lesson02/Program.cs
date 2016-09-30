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
 *  1.2 add event subscription and handling code
 *  1.3 add call to ShapeName property of Rectangle class
 */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lesson02");
            //Create a Rectangle object, get it's area.
            Rectangle rect = new Rectangle();
            rect.Changed += new EventHandler(r_changed);    //subscribe to the event
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Shape Name: {0} Area of {0}: {1}", Rectangle.ShapeName, area);
        }

        //Callback code to be executed when event is published
        static void r_changed(object sender, EventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", rect.Length);
        }

    }
}
