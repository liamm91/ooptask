using System;
using color;
using vector3;

namespace shape3d
{
    public class Shape3d
    {
        // variables
        protected String _shape;
        protected Color _color;
        protected Vector3 _position;

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
}