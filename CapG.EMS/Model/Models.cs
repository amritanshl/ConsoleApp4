using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapG.EMS.Model
{

    public enum EmployeeType
    {
        Fulltime, 
        Contractor, 
        Intern
    }
    public struct Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        

        public Address(string street, string city, string state, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
            
        }
        public override string ToString()
        {
            return $"{Street} | {City} | {State} | {PostalCode}";
        }
    }
  
    public class Models
    {
    }
}
