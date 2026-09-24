using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
    public class Sensor_H:Isensor
    {
        public string Tipo => "Humedad [%]";
        

        public double LeerValor()
        {
            double numero = Random.Shared.Next(0, 101);
            return numero;
        }

    }
}
