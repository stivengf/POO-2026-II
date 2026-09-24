using System;
using System.Collections.Generic;
using System.Text;

namespace EJEMPLO2
{
        public abstract class DecoratorSensor:Isensor
        {
            protected Isensor _sensor;

            public DecoratorSensor(Isensor sensor)
            {
                _sensor=sensor;
            }
            public virtual string Tipo => _sensor.Tipo;

            public virtual double LeerValor()
            {
                return _sensor.LeerValor();
            }
        }
    
}
