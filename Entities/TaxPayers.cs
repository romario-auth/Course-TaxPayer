using System.Text;
using System.Globalization;

namespace TaxPayer.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }
        public double AnnualIncome {get; protected set;}

        public TaxPayers()
        {

        }

        public TaxPayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            StringBuilder printTaxPayer = new StringBuilder();
            printTaxPayer.Append(Name);
            printTaxPayer.Append(" : $ ");
            printTaxPayer.AppendLine(Tax().ToString("F2", CultureInfo.InvariantCulture));

            return printTaxPayer.ToString();             
        }
    }
}