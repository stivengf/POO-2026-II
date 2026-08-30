using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace DemoISP
{
    public interface IOps_cientificas : IOps_Basic
    {
        public double Potencia(double a, double b);
        public double Logaritmo(double a, double b);
    }
}
