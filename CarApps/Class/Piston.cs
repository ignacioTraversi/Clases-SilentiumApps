using System;
using System.Collections.Generic;
using System.Text;

namespace CarApps
{
    public class Piston
    {
        private Motor Motor;

        public Piston(IMotoActions motor)
        {
            Motor = Motor;
        }
        public void ArrancarPiston()
        {
            Console.WriteLine("Pistón arranca");
        }
    }
}
