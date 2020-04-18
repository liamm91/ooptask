using System;
using color;
using shape3d;

namespace torus
{
    class torus : Shape3d
    {
        // variables
        // calculated
        private double _volume;
        private double _surfacearea;
        private double _aspectratio;

        // given in constructor
        private double _majorradius;
        private double _minorradius;

        // constructors
        public torus (double major, double minor, Color color){
            this._majorradius = major;
            this._minorradius = minor;
            this._color = color;

            _update();
        }

        // empty constructor
        public torus () {}

        // methods
        private void _calcvolume(){
            this._volume = (2 * Math.Pow(Math.PI, 2)) * (this._majorradius * Math.Pow(this._minorradius, 2));
        }

        private void _calcsurfacearea(){
            this._surfacearea = 4 * Math.Pow(Math.PI, 2) * this._majorradius * this._minorradius;
        }

        private void _detshape(){
            if (this._majorradius > this._minorradius) {
                this._shape = "Ring torus";
            } else if (this._majorradius == this._minorradius) {
                this._shape = "Horn torus";
            } else if (this._majorradius < this._minorradius) {
                this._shape = "Self-intersecting spindle torus";
            }
        }

        private void _detratio(){
            this._aspectratio = this._majorradius / this._minorradius;
        }

        private void _update(){
            _calcvolume();
            _calcsurfacearea();
            _detshape();
            _detratio();
        }

        public void draw(){
            Console.WriteLine("This is a {0}", this._shape);
            Console.WriteLine("This torus has a color of {0}", this._color);
            Console.WriteLine("The major radius is {0} and the minor radius is {1}", this._majorradius, this._minorradius);
            Console.WriteLine("The surface area of the torus is {0}", this._surfacearea);
            Console.WriteLine("The volume of the torus is {0}", this._volume);
            Console.WriteLine("The aspect ratio of the torus is {0}:1", this._aspectratio);
        }

        // getters / setters
        public double major
        {
            get
            {
                return this._majorradius;
            }
            set
            {
                this._majorradius = value;
                _update();
            }
        }

        public double minor
        {
            get
            {
                return this._minorradius;
            }
            set
            {
                this._minorradius = value;
                _update();
            }
        }

        public override String shape {get => this._shape;}

        public double volume {get => this._volume;}
        public double surfacearea {get => this._surfacearea;}
    }
}