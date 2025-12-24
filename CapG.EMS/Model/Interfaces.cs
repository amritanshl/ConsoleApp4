using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapG.EMS.Model
{

    public interface IPayable
    {
        decimal CalucateSalary();
        void GenerateSalarySlip();

    }

    public interface IReviewable
    {
        void GenerateReview();
    }
    
}
