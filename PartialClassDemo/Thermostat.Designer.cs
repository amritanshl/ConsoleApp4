using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Thermostat
    {
        private double _currentTemprature;
        public void PowerOn()
        {
            _currentTemprature = 20.0;
            Console.WriteLine("AC is on");
        }
    }
}
