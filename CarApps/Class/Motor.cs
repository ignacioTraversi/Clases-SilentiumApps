using CarApps.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarApps
{
    public class Motor: IMotoActions
    {
        private Piston Piston;

        private Automovil Auto;

        public Motor(Automovil auto)
        {
            Piston = new Piston(this);
            Auto = Auto;
        }

        public void ArrancoPiston ()
        {
            throw NotImplementedException();
        }

        public void ArrancarMotor()
        {
            Piston.ArrancarPiston;
        }
    }
}
