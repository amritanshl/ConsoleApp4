using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    public class CalculatorBase
    {

        public string BrandName = "Casio calc";
        private string _serialCode = "A-777-XYZ";
        protected string BasicMathLogic = "Standart-Calc";
        internal string password = "Admin@123";

    }
}
