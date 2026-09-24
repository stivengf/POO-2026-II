using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
    public class Sensor_T:Isensor
    {
        public string Tipo => "Temperatura [F]";


        public double LeerValor()
        {
            double numero = Random.Shared.Next(31, 90);
            return numero;
        }

    }
}
