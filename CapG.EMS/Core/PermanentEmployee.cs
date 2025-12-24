using CapG.EMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapG.EMS.Core
{
    public class PermanentEmployee : Employee, IPayable, IReviewable
    {
        public decimal Salary { get; set; }
        public PermanentEmployee(int id, string name, Address address, EmployeeType role, decimal salary) : base(id, name, address, role) { 
        Salary=salary;
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Pattern matched!!!!!");
        }
        public decimal CalucateSalary()
        {
            Console.WriteLine("Salary is calculated");
            return Salary;
        }
        public void GenerateSalarySlip()
        {
            Console.WriteLine("Salary slip is generated");
        }
        public void GenerateReview()
        {
            Console.WriteLine("Review Generated");
        }

    }
}
