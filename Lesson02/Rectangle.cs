using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02
{

    /**
     *  1.0 inital iteration of class
     *  1.1 remove constructor, replace with Properties (inc get and set) Length & Width
     *
     */

    class Rectangle
    {
        private double length;
        private double width;
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
                    length = value; // 'value' is a keyword
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


        public double GetArea()
        {
            return length * width;
        }
    }
}
