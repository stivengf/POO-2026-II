using System;
using System.Collections.Generic;
using System.Text;

namespace DemoISP
{
    public class Calc_Simple : IOp_basic
    {
        public double Sumar(double a, double b) => a + b;
    }
}
