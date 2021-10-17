namespace Course_137_ExeProp.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; private set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            return NumberOfEmployees <= 10 ? AnualIncome * 0.16 : AnualIncome * 0.14;
        }

    }
}
