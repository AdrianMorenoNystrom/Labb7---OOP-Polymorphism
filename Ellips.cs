using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Ellips:Geometri
    {
        private int lengthA { get; set; }
        private int lengthB { get; set; }

        public Ellips()
        {
            lengthA = 9;
            lengthB = 12;
        }

        public override double Area()
        {
            return Math.PI * lengthA * lengthB;
        }
    }
}
