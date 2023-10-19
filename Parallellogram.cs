using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7___OOP_Polymorphism
{
    internal class Parallellogram:Geometri
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Parallellogram()
        {
            Base = 5;
            Height = 7;
        }

        public override double Area()
        {
            return Base * Height;
        }
    }
}
