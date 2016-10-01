using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lesson02
{
    /**
      *  1.0 Inital iteration of class
      *  1.1 make class abstract, add abstract method GetArea()
      *  1.2 Add virtual method Draw(), Make class non-abstract.
      *  
      */


    class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        //abstract public double GetArea();   //abstract so no class body {}

        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }

    }
}
