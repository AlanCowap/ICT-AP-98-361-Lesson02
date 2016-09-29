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
     */

    class Rectangle
    {
        private double length;
        private double width;
        public event EventHandler Changed;

        //Properties
        public double Length    // convention is properties are public, and name begins with uppercase letter
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)   // Properties allow for validation
                {
                    length = value; // 'value' is a keyword
                    Changed(this, EventArgs.Empty); // publish an event
                }
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0)
                    width = value;
            }
        }

        //Auto-implemented Properties (since version 3), convenient if a simple set and/or get.
        // can have either get or set (since version 6)
        //public double Length { get; set; }
        //public double width { get; set; }
        

        public double GetArea()
        {
            return length * width;
        }
    }
}
