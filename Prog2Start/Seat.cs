using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Seat : Furniture
    {
        private int _seats, _legs;

        //Initalize object, including base furniture variables
        public Seat(decimal price, string category, double weight, int seats, int legs) : base(price, category, weight)
        {
            Seats = seats;
            Legs = legs;
        }
        //Get-set variables
        public int Seats
        {
            get
            {
                return _seats;
            }
            set
            {//If number of seats is above 0 and below 24
                if (value > 0 && value <= 24)
                {
                    _seats = value;
                }
                else
                {//If number of seats is below 0 or above 24, or otherwise invalid
                    throw new ArgumentOutOfRangeException("Invalid Number of Seats!");
                }
            }
        }

        public int Legs
        {
            get
            {
                return _legs;
            }
            set
            {
                if (value > 0 && value <= 10)
                {//If number of legs is above 0 and below 10
                    _legs = value;
                }
                else
                {//If number of legs is below 0 or above 10, or otherwise invalid
                    throw new ArgumentOutOfRangeException("Invalid Number of Legs!");
                }
            }
        }

        public double WeightPerLeg()
        {
            return Weight / Legs;
        }

        public override string ToString()
        {
            return $"The seat has {Legs} legs and can sit {Seats}. It weighs {Weight:g2} pounds and cost {Price:c}. It is categorized as a {Category}";
        }
    }
}
