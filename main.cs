using System;
using shape3d;
using torus;
using triangularprism;
using dodecahedron;
using System.Collections;

namespace computer_science_12
{
    class testing
    {
        static void Main(string[] Args)
        {
            // tori
            Shape3d torus1 = new Torus(10, 5);
            Shape3d torus2 = new Torus(5, 5);
            Shape3d torus3 = new Torus(5, 10);

            // dodecahedron
            Shape3d dodeceda = new Dodecahedron(15);

            // triangular prism
            Shape3d prism1 = new Triangularprism(10, 1, 5, 25);
            Shape3d prism2 = new Triangularprism(10, 25, 4);
            
            // show casing them
            ArrayList shapesList = new ArrayList();
            shapesList.Add(torus1);
            shapesList.Add(torus2);
            shapesList.Add(torus3);
            shapesList.Add(dodeceda);
            shapesList.Add(prism1);
            shapesList.Add(prism2);

            foreach (Shape3d shape in shapesList)
            {
                shape.draw();
            }
        }
    }
}
