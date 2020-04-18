using System;
using shape3d;
using color;
using vector3;

namespace triangularprism
{
    class Triangularprism : Shape3d
    {
        // variables
        // calculated
        private double _latsurfacearea;

        // given
        private double _a; // a is the base of the prism
        private double _b; // lateral side
        private double _c; // lateral side
        private double _h; // height relative to a


        // constructors
        public Triangularprism (double a, double b, double c, double height, Color color)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._h = height;
            this._color = color;
            this._position = new Vector3(0, 0, 0);

            _update();
        }

        public Triangularprism (double a, double b, double c, double height, Color color, Vector3 origin)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._h = height;
            this._color = color;
            this._position = origin;

            _update();
        }

        public Triangularprism (double a, double b, double c, double height, Vector3 origin)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._h = height;
            this._color = presets.Green;
            this._position = origin;
            
            _update();
        }

        public Triangularprism (double a, double b, double c, double height)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            this._h = height;
            this._color = presets.Green;
            this._position = new Vector3(0, 0, 0);
            
            _update();
        }

        // empty constructors
        public Triangularprism () {this._shape = "Triangular Prism";}

        // methods
        private void _update()
        {
            _validate();
            _detshape();
            _calcvolume();
            _calcsurfacearea();
            _calclatsurfacearea();
        }

        // all forumulas from google
        private double descriminant() => Math.Sqrt((-1 * Math.Pow(this._a, 4))+(2 * Math.Pow((this._a * this._b), 2))+(2 * Math.Pow((this._a * this._c), 2))+((-1 * Math.Pow(this._b, 4)))+(2 * Math.Pow((this._b * this._c), 2))+((-1 * Math.Pow(this._c, 4))));
        private void _calcvolume()
        {
            this._volume = ((0.25) * this._h) * descriminant();
        }
        private void _calcsurfacearea()
        {
            this._surfacearea = (this._h * (this._a + this._b + this._c)) * 0.50 * descriminant();
        }
        private void _calclatsurfacearea()
        {
            this._latsurfacearea = (this._a + this._b + this._c) * this._h;
        }
        private void _detshape()
        {
            if (this._a == this._b && this._b == this._c && this._c == this._a)
            {
                this._shape = "Equilateral Triangular Prism";
            } else if (this._b == this._c){
                this._shape = "Isoceles Triangular Prism";
            } else {
                this._shape = "Scalene Triangular Prism";
            }
        }

        // constraint (b + c) > a
        // constraint (a + c) > b
        // constraint (a + b) > c
        private void _validate()
        {
            if (this._a <= 0) {
                throw new ArgumentException("The base of the prism cannot be less than or be 0");
            } else if (this._b <= 0 || this._c <= 0){
                throw new ArgumentException("The side of the prism cannot be less than or be 0");
            } else if (this._h <= 0){
                throw new ArgumentException("The height of the prism cannot be less than or be 0");
            } else if ((this._b + this._c) <= this._a){
                throw new ArgumentException("(b + c) > a");
            } else if ((this._a + this._c) <= this._b){
                throw new ArgumentException("(a + c) > b");
            } else if ((this._a + this._b) <= this._c){
                throw new ArgumentException("(a + b) > c");
            }
        }

        public override void draw()
        {
            Console.WriteLine("This is a {0} located at {1}", this._shape, this._position);
            Console.WriteLine("This prism has a color of {0}", this._color);
            Console.WriteLine("This prism has a base of height {0}", this._a);
            Console.WriteLine("The surface area of the prism is {0:0.00}", this._surfacearea);
            Console.WriteLine("The volume of the prism is {0:0.00}", this._volume);
            Console.WriteLine("The lateral surface area of the prism is {0:0.00}", this._latsurfacearea);
        }
        
        // getters and setters
        public double lateralsurfacearea {get => this._latsurfacearea;}
        public override String shape {get => this._shape;}
        public double prismbase 
        {
            get
            {
                return this._a;
            }
            set
            {
                this._a = value;
                _update();
            }
        }
        public double b 
        {
            get
            {
                return this._b;
            }
            set
            {
                this._b = value;
                _update();
            }
        }
        public double c 
        {
            get
            {
                return this._c;
            }
            set
            {
                this._c = value;
                _update();
            }
        }
        public double height 
        {
            get
            {
                return this._h;
            }
            set
            {
                this._h = value;
                _update();
            }
        }
    }
}