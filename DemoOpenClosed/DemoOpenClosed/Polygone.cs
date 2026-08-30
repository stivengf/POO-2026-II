using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Polygone : Shape
    {
        public double Apothem { get; set; }
        public double Size { get; set; }
        public double Num_Size { get; set; }
        public override double Area() => (this.Apothem * this.Size*this.Num_Size)/2;
    }
}
