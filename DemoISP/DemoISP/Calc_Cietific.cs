using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace DemoISP
{
    public class Calc_Cietific : IOps_cientificas
    {
        public double Sumar(double a, double b) => a + b;
        public double Restar(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b) => a / b;
        public double Potencia(double a, double b) => Math.Pow(a, b);
        public double Logaritmo(double a, double b) => Math.Log(a, b);

    }
}
