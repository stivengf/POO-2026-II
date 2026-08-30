using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Circle : Shape
    {
        public double Radious { get; set; }
        public override double Area() => this.Radious * this.Radious * Math.PI;
    }
}
