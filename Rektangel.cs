using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    public class Rektangel:Geometri
    {
        public int length { get; set; }
        public int width { get; set; }

        public Rektangel()
        {
            length = 7;
            width = 9;
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
