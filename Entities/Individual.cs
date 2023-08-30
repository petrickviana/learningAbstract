using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstração.Entities
{
    class Individual : Person
    {
        public double HealthCosts { get; set; }

        public Individual(string name, double anualIncome, double healthCosts) : base(name, anualIncome)
        {
            HealthCosts = healthCosts;
        }


        public override double taxFee()
        {
            if (AnualIncome < 20000)
            {
                return AnualIncome*0.15 - 0.5 * HealthCosts;
            }
            else
            {
                return AnualIncome * 0.25 - 0.5 * HealthCosts;
            }
        }

    }
}
