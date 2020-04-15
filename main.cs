using System;
using color;
using vector3;
using shape3d;

namespace computer_science_12
{
    class testing
    {
        static void Main(string[] Args)
        {
            Shape3d red = new Shape3d("Sphere", new Color("#FFAAFF"), new Vector3(1,1,1));
            Console.WriteLine(red.color);
            Console.WriteLine(red.shape);
            Console.WriteLine(red.position);
        }
    }
}
