using System.Text;
using System.Globalization;

namespace TaxPayer.Entities
{
    class Individual : TaxPayers
    {
        public double HealthExpenditures {get; protected set;}

        public Individual()
        {

        }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if ( AnnualIncome < 20000 )
            {
                tax += AnnualIncome * 0.15;
            } else
            {
                tax += AnnualIncome * 0.25;
            }

            return tax - (HealthExpenditures * 0.50);
        }
    }
}