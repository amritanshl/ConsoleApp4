using CapG.EMS.Core;
using CapG.EMS.Model;

namespace CapG.EMS.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeType empPer = EmployeeType.Fulltime;
            EmployeeType empCon = EmployeeType.Contractor;
            EmployeeType empIntern = EmployeeType.Intern;
            Address capgAd = new Address("Brookefield","Banglore", "KA", "506066");
            Address rekhaAdd = new Address("Airoli", "Mumbai", "KA", "100101");
            PermanentEmployee trainerEmp = new PermanentEmployee(111, "Amrit",capgAd,empCon,1000000 );
            ContractEmployee userEmp = new ContractEmployee(111, "Rekha",rekhaAdd,empPer,20000 );

        }
    }
}