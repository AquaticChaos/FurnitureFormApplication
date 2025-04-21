using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class Furniture
    {
        private decimal _price;
        private double _weight;
        private string _category;

        public Furniture(decimal price, string category, double weight) 
        {
            //Initialize object
            Price = price;
            Category = category;
            Weight = weight;
        }

        //Get-set all variables
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                //If price is above 0
                if (value > 0.0m)
                {
                    _price = value;
                }
                else //If price is below 0
                {
                    throw new ArgumentOutOfRangeException("Invalid Price!");
                }
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                //If weight is above 0 and below 1000
                if (value > 0 && value <= 1000)
                {
                    _weight = value;
                }
                else
                {//If weight is below 0 or above 1000
                    throw new ArgumentOutOfRangeException("Invalid Weight!");
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                //If string is empty
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Invalid Category!");
                }
                else
                {//If string isn't empty
                    _category = value;
                }
            }
        }
    }
}
