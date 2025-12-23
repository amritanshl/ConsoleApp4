using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_class
{
    // File: Thermostat.Logic.cs
    public partial class Thermostat
    {
        public void AdjustTemperature(double delta)
        {
            _currentTemperature += delta;
            Console.WriteLine($"Temperature adjusted to: {_currentTemperature}°C");

            if (_currentTemperature > 30)
            {
                TriggerCooling();
            }
        }

        private void TriggerCooling()
        {
            Console.WriteLine("Warning: High temp! Cooling system engaged.");
        }

        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat();
            thermostat.AdjustTemperature(10);
            thermostat.TriggerCooling();
            thermostat.InitializeHardware();
        }
    }
}