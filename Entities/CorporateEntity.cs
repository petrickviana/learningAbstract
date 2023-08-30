using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração.Entities
{
    class CorporateEntity : Person
    {
        public int EmployeeAmount { get; set; }

        public CorporateEntity(string name, double anualIncome, int employeeAmount) : base(name, anualIncome)
        {
            EmployeeAmount = employeeAmount;
        }

        public override double taxFee()
        {
            if (EmployeeAmount < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }






}



