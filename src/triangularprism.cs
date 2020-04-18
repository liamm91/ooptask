using System;
using shape3d;
using color;

namespace triangularprism
{
    class triangularprism : Shape3d
    {
        // variables
        // calculated
        private double _volume;
        private double _surfacearea;
        private double _basearea;
        private double _latsurfacearea;

        // given
        private double _base; // a is the base of the prism
        private double _b; // lateral side
        private double _c; // lateral side
        private double _l; // length
        private double _h; // height relative to a


        // constructors
        public triangularprism (double _base, double latside1, double latside2, double length, Color color)
        {
            this._base = _base;
            this._b = latside1;
            this._c = latside2;
            this._l = length;
            this._color = color;

            _calcheight();
            _update();
        }

        public triangularprism (double _base, double latside1, double latside2, double length)
        {
            this._base = _base;
            this._b = latside1;
            this._c = latside2;
            this._l = length;
            this._color = presets.Green;
            
            _calcheight();
            _update();
        }

        // using _base because base is a keyword/function
        public triangularprism (double _base, double height, double length, Color color)
        {
            this._base = _base;
            this._h = height;
            this._l = length;
            this._color = color;

            _calcothersides();
            _update();
        }

        public triangularprism (double _base, double height, double length)
        {
            this._base = _base;
            this._h = height;
            this._l = length;
            this._color = presets.Green;

            _calcothersides();
            _update();
        }

        // empty constructors
        public triangularprism () {this._shape = "Triangular Prism";}

        // methods
        private void _update()
        {
            _validate();
            _detshape();
            _calcvolume();
            _calcsurfacearea();
            _calcbasearea();
            _calclatsurfacearea();
        }

        // reoccuring function within the calculations of a triangular prism
        private double _descriminant => Math.Sqrt((-1 * Math.Pow(this._base, 4)) + (2 * Math.Pow((this._base * this._b), 2)) + (2 * Math.Pow((this._base * this._c), 2)) + (-1 * Math.Pow(this._b, 4) + (2 * Math.Pow((this._b * this._c), 2)) + (-1 * Math.Pow(this._c, 4))));

        private void _calcvolume()
        {
            this._volume = (1/2) * this._base * this._h * this._l;
        }
        private void _calcsurfacearea()
        {
            double s = Math.Sqrt((Math.Pow(this._base / 2, 2))+(Math.Pow(this._h, 2)));
            this._surfacearea = (this._base * (this._h + this._l)) + (2 * this._l * s);
        }
        private void _calcbasearea()
        {
            this._basearea = (1/4) * _descriminant;
        }
        private void _calclatsurfacearea()
        {
            this._latsurfacearea = (this._base + this._b + this._c) * this._h;
        }
        private void _calcheight()
        {
            double s = (this._base + this._b + this._c) / 2;
            this._h = (2 / this._base) * Math.Sqrt(s * (s - this._base) *  (s - this._b) * (s - this._c));
        }
        private void _calcothersides()
        {
            this._b = this._c = Math.Sqrt((Math.Pow(this._base / 2, 2))+(Math.Pow(this._h, 2)));
        }
        private void _detshape()
        {
            if (this._base == this._b && this._b == this._c && this._c == this._base)
            {
                this._shape = "Equilateral Triangular Prism";
            } else if (this._b == this._c){
                this._shape = "Isoceles Triangular Prism";
            } else {
                this._shape = "Scalene Triangular Prism";
            }
        }
        private void _validate()
        {
            if (this._base <= 0) {
                throw new ArgumentException("The base of the prism cannot be less than or be 0");
            } else if (this._b <= 0 || this._c <= 0){
                throw new ArgumentException("The side of the prism cannot be less than or be 0");
            } else if (this._h <= 0){
                throw new ArgumentException("The height of the prism cannot be less than or be 0");
            } else if (this._l <= 0){
                throw new ArgumentException("The base of the prism cannot be less than or be 0");
            }
        }
        
        // getters and setters
        public double volume {get => this._volume;}
        public double surfacearea {get => this._surfacearea;}
        public double basearea {get => this._basearea;}
        public double lateralsurfacearea {get => this._latsurfacearea;}
        public override String shape {get => this._shape;}
    }
}