namespace Course_137_ExeProp.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualIncome { get; private set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

    }
}
