using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOpenClosed
{
    public class Area_calculator
    {
        

        public double Area_Total(List<Shape> shapes) => shapes.Sum(shape => shape.Area());
    }
}
