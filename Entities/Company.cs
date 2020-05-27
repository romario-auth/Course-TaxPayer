namespace TaxPayer.Entities
{
    class Company : TaxPayers
    {
        public int NumberOfEmployees {get; protected set;}

        public Company()
        {

        }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if ( NumberOfEmployees < 10 )
            {
                return AnnualIncome * 0.16;
            } else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}