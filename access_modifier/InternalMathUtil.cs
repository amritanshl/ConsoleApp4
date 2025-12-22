using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_modifier
{
    public class InternalMathUtil : CalculatorBase
    {
        public void CheckAccess()
        {
            Console.WriteLine(BrandName);
            Console.WriteLine(BasicMathLogic);
            Console.WriteLine(password);
           // Console.WriteLine();
        }
    }
}
