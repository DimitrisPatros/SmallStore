namespace SmallStore
{
    //POCO Class
    class Product
    {
        private int Id { get; set; }
        private string ProductName { get; set; }
        public double PriceWhenBuy { get; set; }
        public double PriceWhenSell { get; set; }

        public Product() { }

        public Product(int id, string productName, double priceWhenBuy, double priceWhenSell)
        {
            Id = id;
            ProductName = productName;
            PriceWhenBuy = priceWhenBuy;
            PriceWhenSell = priceWhenSell;
        }

        public override string ToString()
        {
            return $"Product ID [{Id}], Product Name: {ProductName}," +
                   $" Bought at :{PriceWhenBuy} and sell at :{PriceWhenSell}";
        }
    }
}
