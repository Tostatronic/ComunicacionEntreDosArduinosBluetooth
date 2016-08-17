using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControladorRGBApp
{
    class SensorNotFoundExceptio : Exception
    {
        public SensorNotFoundExceptio()
        {
        }
        public SensorNotFoundExceptio(string message)
            : base(message)
        {
        }
        public SensorNotFoundExceptio(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected SensorNotFoundExceptio(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        {
        }
    }
}
