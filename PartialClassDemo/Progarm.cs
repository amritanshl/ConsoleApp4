using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
     class Progarm
    {
static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            thermostat.PowerOn();
            thermostat.Display();
        }
        
    }
}
