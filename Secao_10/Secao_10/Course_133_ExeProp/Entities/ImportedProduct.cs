using System.Globalization;

namespace Course_133_ExeProp.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}" +
                $" (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
