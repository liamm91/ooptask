using System;

namespace color
{
    public class Color
    {
        // instance variables
        protected int _red;
        protected int _green;
        protected int _blue;
        protected float _alpha;

        // constructors
        // RGB no alpha
        public Color(int red, int green, int blue)
        {
            // testing for exceptions
            int[] temp = {red, green, blue};
            foreach (int col in temp)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }

            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = 1.0f;
        }

        // RGBA
        public Color(int red, int green, int blue, float alpha)
        {
            // testing for exceptions
            int[] temp = {red, green, blue};
            foreach (int col in temp)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }
            if (alpha > 1.0f || alpha < 0.0f)
            {
                return;
            }

            this._red = red;
            this._green = green;
            this._blue = blue;
            this._alpha = alpha;
        }

        // unpack a list no alpha
        public Color(int[] rgb)
        {
            // testing for exceptions
            foreach (int col in rgb)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }
            if (alpha > 1.0f || alpha < 0.0f)
            {
                return;
            }

            this._red = rgb[0];
            this._green = rgb[1];
            this._blue = rgb[2];
            this._alpha = 1.0f;
        }

        // unpack a list and alpha
        public Color(int[] rgb, float alpha)
        {
            // testing for exceptions
            foreach (int col in rgb)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }
            if (alpha > 1.0f || alpha < 0.0f)
            {
                return;
            }

            this._red = rgb[0];
            this._green = rgb[1];
            this._blue = rgb[2];
            this._alpha = alpha;
        }

        // unpack a hexadecimal string no alpha
        // #FFAAFF - example hex color string
        // 0123456 - character indexes
        public Color(String color)
        {
            if (color.Length != 7) { return; }
            this._red = int.Parse(color.ToLower().Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            this._green = int.Parse(color.ToLower().Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            this._blue = int.Parse(color.ToLower().Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            this._alpha = 1.0f;

            int[] temp = {_red, _green, _blue};
            foreach (int col in temp)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }
        }

        // unpack a hexadecimal string and alpha
        // #FFAAFF - example hex color string
        // 0123456 - character indexes
        public Color(String color, float alpha)
        {
            if (color.Length != 7) { return; }
            this._red = int.Parse(color.ToLower().Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
            this._green = int.Parse(color.ToLower().Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
            this._blue = int.Parse(color.ToLower().Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
            this._alpha = alpha;

            int[] temp = {_red, _green, _blue};
            foreach (int col in temp)
            {
                if (col < 0 || col > 255)
                {
                    return;
                }
            }
            if (_alpha > 1.0f || _alpha < 0.0f)
            {
                return;
            }
        }

        // empty constructor
        public Color() { }

        // overrides
        public override string ToString()
        {
            String[] temp = { "#", _red.ToString("x2"), _green.ToString("x2"), _blue.ToString("x2") };
            return String.Join("", temp);
        }

        // remove function, to delete set var to 'null'

        // getters / setters
        public int red
        {
            get
            {
                return _red;
            }
            set
            {
                if (value.GetType() == typeof(int))
                {
                    if (_red < 0 || _red > 255)
                    {
                        return;
                    } else 
                    {
                        this._red = value;
                    }
                }
            }
        }

        public int green
        {
            get
            {
                return _green;
            }
            set
            {
                if (value.GetType() == typeof(int))
                {
                    if (_green < 0 || _green > 255)
                    {
                        return;
                    } else 
                    {
                        this._green = value;
                    }
                }
            }
        }

        public int blue
        {
            get
            {
                return _blue;
            }
            set
            {
                if (value.GetType() == typeof(int))
                {
                    if (_blue < 0 || _blue > 255)
                    {
                        return;
                    } else 
                    {
                        this._blue = value;
                    }
                }
            }
        }

        public float alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                if (value.GetType() == typeof(float))
                {
                    if (_alpha > 1.0f || _alpha < 0.0f)
                    {
                        return;
                    } else 
                    {
                        this._alpha = value;
                    }
                }
            }
        }

        // getter / setter for hexadecimal color strings
        public String color
        {
            get
            {
                String[] temp = { "#", _red.ToString("x2"), _green.ToString("x2"), _blue.ToString("x2") };
                return String.Join("", temp);
            }
            set
            {
                // unpack a hexadecimal string and alpha
                // #FFAAFF - example hex color string
                // 0123456 - character indexes
                if (value.GetType() == typeof(String) && value.Length == 7)
                {
                    this._red = int.Parse(color.ToLower().Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                    this._green = int.Parse(color.ToLower().Substring(3, 2), System.Globalization.NumberStyles.HexNumber);
                    this._blue = int.Parse(color.ToLower().Substring(5, 2), System.Globalization.NumberStyles.HexNumber);
                }
            }
        }
    }
}