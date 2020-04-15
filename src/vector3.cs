using System;

namespace vector3
{
    public class Vector3
    {
        // instance variables
        protected float _x;
        protected float _y;
        protected float _z;

        // constructors
        public Vector3(float x, float y, float z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        // empty constructor
        public Vector3() { }

        // remove function, to delete set var to 'null'

        // overrides
        public override string ToString()
        {
            String[] temp = { _x.ToString(), ", ", _y.ToString(), ", ", _z.ToString() };
            return String.Join("", temp);
        }

        // getter/setter
        public float[] position {
            get
            {
                float[] temp = { _x, _y, _z };
                return temp;
            }
            set
            {
                float[] temp = value;
                this._x = temp[0]; this._y = temp[1]; this._z = temp[2];
            }
        }

        public float x
        {
            get
            {
                return _x;
            }
            set
            {
                if (value.GetType() == typeof(float))
                {
                    this._x = value;
                }
            }
        }

        public float y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value.GetType() == typeof(float))
                {
                    this._y = value;
                }
            }
        }

        public float z
        {
            get
            {
                return _z;
            }
            set
            {
                if (value.GetType() == typeof(float))
                {
                    this._z = value;
                }
            }
        }
    }
}