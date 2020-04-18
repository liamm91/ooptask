using System;
using shape3d;
using color;

namespace dodecahedron
{

    class dodecahedron : Shape3d
    {
        // variables
        // calculated
        private double _volume;
        private double _surfacearea;

        // given
        private double _edgelength;

        // constructors
        public dodecahedron (double edge, Color color)
        {
            this._edgelength = edge;
            this._color = color;
            this._shape = "Dodecahedron";
            _update();
        }

        public dodecahedron (double edge)
        {
            this._edgelength = edge;
            this._color = presets.Red;
            this._shape = "Dodecahedron";
            _update();
        }

        // empty constructors
        public dodecahedron () {this._shape = "Dodecahedron";}

        // methods
        private void _update()
        {
            _calcsurfacearea();
            _calcvolume();
        }

        private void _calcsurfacearea()
        {
            this._surfacearea = (3 * Math.Sqrt(25 + (10 * Math.Sqrt(5))) * Math.Pow(this._edgelength, 2));
        }

        private void _calcvolume()
        {
            this._volume = ((15 + (7 * Math.Sqrt(5))) / 4) * (Math.Pow(this._edgelength, 3));
        }

        public void draw()
        {
            Console.WriteLine("This is a {0}", this._shape);
            Console.WriteLine("This dodecahedron has a color of {0}", this._color);
            Console.WriteLine("The surface area of the dodecahedron is {0}", this._surfacearea);
            Console.WriteLine("The volume of the dodecahedron is {0}", this._volume);
        }
        
        // getters and setters
        public double volume {get => this._volume;}
        public double surfacearea {get => this._surfacearea;}
        public override String shape {get => this._shape;}
        public double edge_length
        {
            get
            {
                return this._edgelength;
            }
            set
            {
                this._edgelength = value;
                _update();
            }
        }
    }
}