using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    public class DeskChair : Seat
    {
        //Initialize object, including base furniture and seat variables
        public DeskChair(decimal price, string category, double weight, int seats, int legs, bool spin) : base(price, category, weight, seats, legs) 
        {
            Spin = spin;
        }

        //Get-set variables
        public bool Spin
        {
            get; set;
        }

        public override string ToString()
        {
            //Convert boolean into a string
            string spin = Spin ? "It spins!" : "It doesn't spin :(";
            return $"The desk chair has {Legs} legs and can sit {Seats}. It weighs {Weight:g2} pounds and cost {Price:c}. It is categorized as a {Category}. {spin}";
        }
    }
}
