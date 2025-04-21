using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Cushion
    {
        private string _material;
        private double _length, _width, _height;

        //Initialize object
        public Cushion(string material, double length, double width, double height)
        {
            Material = material;
            Length = length;
            Width = width;
            Height = height;
        }
        //Get-set variables
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {//If length is above 0 and below 24
                if (value > 0 && value <= 24)
                {
                    _length = value;
                }
                else
                {//If length is below 0 or above 24, or otherwise invalid
                    throw new ArgumentOutOfRangeException("Invalid Length!");
                }
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {//If width is above 0 and below 24
                if (value > 0 && value <= 24)
                {
                    _width = value;
                }
                else
                {//If width is below 0 or above 24, or otherwise invalid
                    throw new ArgumentOutOfRangeException("Invalid Width!");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {//If height is above 0 and below 24
                if (value > 0 && value <= 24)
                {
                    _height = value;
                }
                else
                {//If height is below 0 or above 24, or otherwise invalid
                    throw new ArgumentOutOfRangeException("Invalid Height!");
                }
            }
        }



        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || (value != "Foam" && value != "Stuffing"))
                {//If string is empty, or is not either foam or stuffing
                    throw new ArgumentOutOfRangeException("Invalid Cushion Material!");
                }
                else
                {//If string is foam or stuffing
                    _material = value;
                }
            }
        }

        public double CalcVolume()
        {
            return Length * Width * Height;
        }

        public override string ToString()
        {
            return $"The cusion measures {Height} inches tall, {Width} inches wide, and {Length} inches long. It is made from {Material}";
        }
    }
}
