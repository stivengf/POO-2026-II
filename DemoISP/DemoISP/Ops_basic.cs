using System;
using System.Collections.Generic;
using System.Text;

namespace DemoISP
{
    public interface IOps_Basic : IOp_basic
    {
        public double Restar(double a, double b);
        public double Multiplicar(double a, double b);
        public double Dividir(double a, double b);
    }
}
