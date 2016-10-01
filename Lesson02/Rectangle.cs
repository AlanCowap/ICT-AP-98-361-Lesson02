using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{

    /**
     *  1.0 Inital iteration of class
     *  1.1 Remove constructor, replace with Properties (inc get and set) Length & Width
     *  1.2 Add sample code for auto-implemented properties
     *  1.3 Add Event publication when length changed
     *  1.4 Add ShapeName property, modify GetArea() to use properties rather than fields
     *  1.5 Add a struct: Point
     *  1.6 Extend Polygon, Add constructor, Remove Property for Length and Width (since now inherited from Polygon).
     *  1.7 Make GetArea() override the base class
     *  1.8 Implement Draw()
     *  1.9 Implement IComparable
     *  
     */

    class Rectangle : Polygon, IComparable
    {
        //private double length;
        //private double width;
        public event EventHandler Changed;

        //Constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        //Properties
        //public double Length    // convention is properties are public, and name begins with uppercase letter
        //{
        //    get
        //    {
        //        return length;
        //    }
        //    set
        //    {
        //        if (value > 0.0)   // Properties allow for validation
        //        {
        //            length = value; // 'value' is a keyword
        //            Changed(this, EventArgs.Empty); // publish an event
        //        }
        //    }
        //}
        //public double Width
        //{
        //    get
        //    {
        //        return width;
        //    }
        //    set
        //    {
        //        if (value > 0.0)
        //            width = value;
        //    }
        //}

        public static string ShapeName
        {
            get { return "Rectangle"; }
        }

        //Auto-implemented Properties (since version 3), convenient if a simple set and/or get.
        // can have either get or set (since version 6)
        //public double Length { get; set; }
        //public double width { get; set; }
        

        public double GetArea()
        {
            return Length * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }

        //Implement CompareTo as defined by IComparable interface
        public int CompareTo(object obj)
        {
            if (null == obj)
                return 1;
            if (!(obj is Rectangle))
                throw new ArgumentException();

            Rectangle target = (Rectangle)obj;
            double diff = this.GetArea() - target.GetArea();

            if (0 == diff)
                return 0;       //same
            else if (diff > 0)  //this object is 'bigger'
                return 1;
            else return -1;     //other object is 'bigger'
        }

    }

    //Add a struct
    struct Point
    {
        public double X, Y;
    }

}
