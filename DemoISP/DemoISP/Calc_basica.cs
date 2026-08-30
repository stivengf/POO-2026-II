using System;
using System.Collections.Generic;
using System.Text;

namespace DemoISP
{
    public class Calc_basica : IOps_Basic
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a*b;
        public double Dividir(double a, double b) => a/b;
    }
}
