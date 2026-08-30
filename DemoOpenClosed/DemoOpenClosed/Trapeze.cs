using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Trapeze : Shape
    {
        public double Longer_Base { get; set; }
        public double Shorter_Base { get; set; }
        public double High { get; set; }
        public override double Area() => (this.Longer_Base +  this.Shorter_Base) * this.High/2;
    }
}
