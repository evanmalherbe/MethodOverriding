using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
