using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Fyrkant:Geometri
    {
        public int Sidelength { get; set; }

        public Fyrkant()
        {
            Sidelength = 5;
        }

        public override double Area()
        {
            return Sidelength * Sidelength;
        }
    }
}
