using CarApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarApps
{
    public class Automovil : IAutoActions
    {
        private Motor Motor;

        public Automovil()
        {
            Motor = new Motor(this);
        }

        public void ArrancarAuto()
        {
            Motor.ArrancarMotor();
        }

        public void Arrancar()
        {
            Console.WriteLine("EL MOTOR AVISO");
        }

        public void ArrancarMotor()
        {
            throw new NotImplementedException();
        }
    }
}
