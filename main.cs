using System;
using color;
using vector3;

namespace computer_science_12
{
    public class Shape3d
    {
        // variables
        private String _shape;
        private Color _color;
        private Vector3 _position;

        // constructors
        public Shape3d(String shape, Color color, Vector3 pos)
        {
            this._shape = shape;
            this._color = color;
            this._position = pos;
        }

        // empty constructor
        public Shape3d() { }

        // remove function, to delete set var to 'null'

        // getters/setters
        public String shape
        {
            get
            {
                return _shape;
            }
            set
            {
                _shape = value;
            }
        }

        public Color color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Vector3 position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
    }

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
