using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
    public class SensorCelsius:DecoratorSensor
    {
        public SensorCelsius(Isensor sensor) : base(sensor) { }

        public override string Tipo => _sensor.Tipo.Replace("[F]", "[C]");

        public override double LeerValor()
        {
            double fahrenheit= _sensor.LeerValor();
            return (fahrenheit-32) * 5/9;
        }
    }
}
