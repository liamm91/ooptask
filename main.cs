using System;
using shape3d;
using torus;
using triangularprism;
using dodecahedron;
using System.Collections;
using vector3;

namespace computer_science_12
{
    class testing
    {
        public static void Main(string[] Args)
        {
            // base class
            Shape3d basic = new Shape3d();

            // tori
            Torus torus1 = new Torus(10, 5, new Vector3(25, 2, -3));
            Torus torus2 = new Torus(5, 5);
            Torus torus3 = new Torus(5, 10);

            // dodecahedron
            Dodecahedron dodeceda = new Dodecahedron(15, new Vector3(420, 420, 420));

            // triangular prism
            Triangularprism prism1 = new Triangularprism(10, 9, 5, 25);
            Triangularprism prism2 = new Triangularprism(3, 3, 3, 25, new Vector3(1, 2, 3));
            
            // show casing them, does not give any errors
            ArrayList shapesList = new ArrayList();
            // shapesList.Add(basic);
            // shapesList.Add(torus1);
            // shapesList.Add(torus2);
            // shapesList.Add(torus3);
            // shapesList.Add(dodeceda);
            // shapesList.Add(prism1);
            // shapesList.Add(prism2);

            foreach (Shape3d shape in shapesList)
            {
                shape.draw();
                Console.WriteLine("");
            }

            // accessing the getter / setter of a class
            // Console.WriteLine("The lateral surface area of prism1 is {0}", prism1.lateralsurfacearea);

            /* --------- PROBLEMATIC SHAPES, UNCOMMENT AT OWN RISK --------- */
            // tori
            // Torus err_torus1 = new Torus(10, 0);
            // Torus err_torus2 = new Torus(0, 5);

            // dodecahedron
            // Dodecahedron err_dodeceda = new Dodecahedron(-5);

            // triangular prism
            // Triangularprism err_prism1 = new Triangularprism(10, 1, 1, 25);
            // Triangularprism err_prism2 = new Triangularprism(1, 10, 1, 25);
            // Triangularprism err_prism3 = new Triangularprism(1, 1, 10, 25);
        }
    }
}
