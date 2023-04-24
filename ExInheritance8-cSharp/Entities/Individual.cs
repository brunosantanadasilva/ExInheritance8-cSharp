using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExInheritance8_cSharp.Entities
{
    internal class Individual : TaxPayer
    {
        public  double  HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual (string name, double anualIncome, double healthExpenditures)
            : base (name, anualIncome) 
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;

            if ( AnualIncome < 20000)
            {
                tax = AnualIncome * 15/100;
            }
            else
            {
                tax = AnualIncome * 25/100;
            }

            if ( HealthExpenditures > 0 )
            {
                tax = tax - (HealthExpenditures * 50/100);
            }

            return tax;
        }
    }


}
