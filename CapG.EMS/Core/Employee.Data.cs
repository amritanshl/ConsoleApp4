using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapG.EMS.Model;

namespace CapG.EMS.Model
{
   public abstract partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public Address EmployeeAddress { get; set; }
        public EmployeeType Role { get; set; }
        protected decimal TaxRate { get; set; }
        protected Employee(int id, string name, Address address, EmployeeType role) { 
                 Id = id;
            Name = name;    
            EmployeeAddress = address;
            Role = role;
           
        }
    }
}
