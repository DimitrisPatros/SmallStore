using System;

namespace SmallStore
{
    public class SimpleStore : IStore
    {
        public double TotalBuyBalance { get; set; }
        public double TotalSellBalance { get; set; }

        public void Buy(Product product)
        {
            TotalBuyBalance += product.PriceWhenBuy;
        }

        public void Sell(Product product)
        {
            TotalSellBalance += product.PriceWhenSell;
        }

        public double GetRevenue()
        {
            return TotalSellBalance - TotalBuyBalance;
        }

        public void GetInventory()
        {
            Console.WriteLine("There is no inventory");
        }
    }
}
