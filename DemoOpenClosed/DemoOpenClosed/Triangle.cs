using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double High { get; set; }
        public override double Area() => this.Base* this.High;
    }
}
