using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    interface IDetailsFactory
    {
        public Engine CreateEngine();
        public Suspension CreateSuspension();
        public Wheel CreateWheel();
    }
}
