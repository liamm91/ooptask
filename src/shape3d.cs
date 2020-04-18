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
        protected double _volume;
        protected double _surfacearea;

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

        // methods

        public virtual void draw()
        {
            Console.WriteLine("This is a {0}", this._shape);
            Console.WriteLine("This with a color of {0}", this._color);
            Console.WriteLine("Located at {0]", this._position);
        }

        // getters/setters
        public virtual String shape
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

        public virtual Color color
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

        public virtual Vector3 position
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

        public virtual double volume {get => this._volume;}
        public virtual double surfacearea {get => this._surfacearea;}
    }
}