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
 *  1.4 add code for using struct 'Point'
 *  1.5 add code to demo Polymorphism
 *  1.6 add code comparing 2 objects (who implement IComparable)
 *  
 */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lesson02");

            //Create a couple of structs and see how they operate
            Point p1 = new Lesson02.Point();
            p1.X = 10;
            p1.Y = 20;
            Point p2 = p1;  //p2 struct is a copy of p1 struct, since structs are value types (not reference types)
            p2.X = 100;     // this affects only p2 struct, but no effect on p1 struct
            Console.WriteLine("p1.X = {0}, p2.X = {1}", p1.X, p2.X);

            //Create a Rectangle object, get it's area.
            Rectangle rect = new Rectangle(10, 20);
            rect.Changed += new EventHandler(r_changed);    //subscribe to the event
            //rect.Length = 10.0;
            //rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Shape Name: {0} Width={1} Length={2}, Area={3}", Rectangle.ShapeName, rect.Width, rect.Length, area);

            //Polymorphism
            List<Polygon> polygons = new List<Polygon>();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle(30,40));
            polygons.Add(new Triangle());
            foreach(Polygon p in polygons)
                p.Draw();

            //Compare objects
            Rectangle rect1 = new Rectangle(10, 20);
            Rectangle rect2 = new Rectangle(100, 200);
            Console.WriteLine(rect1.CompareTo(rect2));
            Console.WriteLine(rect2.CompareTo(rect1));
            Console.WriteLine(rect1.CompareTo(rect1));
            Console.WriteLine(rect2.CompareTo(rect2));

        }

        //Callback code to be executed when event is published
        static void r_changed(object sender, EventArgs e)
        {
            Rectangle rect = (Rectangle)sender;
            Console.WriteLine("Value Changed: Length = {0}", rect.Length);
        }

    }
}
