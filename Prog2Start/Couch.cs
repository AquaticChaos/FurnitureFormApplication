using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Couch: Seat
    {
        private string _material;
        private Cushion _cushion;

        //Initialize object, including base furniture and seat variables
        public Couch(decimal price, string category, double weight, int seats, int legs, string material, Cushion cushion) : base(price, category,weight,seats, legs)
        {
            Material = material;
            Cushion = cushion;
        }

        //Get-set variables
        public string Material
        {
            get
            {
                return _material;
            }
            set
            {
                //If string is empty or isn't either leather or textile
                if (string.IsNullOrWhiteSpace(value) || (value != "Leather" && value != "Textile"))
                {
                    throw new ArgumentOutOfRangeException("Invalid Material Entered!");
                }
                else
                {//If string is either leather or textile
                    _material = value;
                }
            }
        }

        public Cushion Cushion
        {
            get { return _cushion; }
            set
            {//If cushion is created
                if (value != null)
                {
                    _cushion = value;
                }
                else
                {//If cushion is empty or null
                    throw new NullReferenceException("No Cushion Object Found!");
                }
            }
        }

    }
}
