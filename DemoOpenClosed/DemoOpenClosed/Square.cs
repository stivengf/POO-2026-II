using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Square : Shape
    {
        public double Size { get; set; }
        public override double Area() => this.Size * this.Size;
    }
}
