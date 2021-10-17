namespace Course_137_ExeProp.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }
        
        public Individual(string name, double anualIncome, double healthexpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthexpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return HealthExpenditures == 0 ? AnualIncome * 0.15 : (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return HealthExpenditures == 0 ? AnualIncome * 0.25 : (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
