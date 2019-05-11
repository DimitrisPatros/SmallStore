using System;
using System.Collections.Generic;
using System.Text;

namespace SmallStore
{
    class SimpleStore : IStore
    {
        //private double _totalBuyBalance;
        //private double _totalSellBalance;

        public Product Product { get; set; }
        public double Revenue { get; private set; }
        public double TotalSellBalance { get; private set; }
        public double TotalBuyBalance { get; private set; }

        //public SimpleStore(Product product)
        //{
        //    Product =product;
        //    Revenue = 0;
        //}

        public double Buy(double price)
        {
            TotalBuyBalance += Product.PriceWhenBuy;
            return TotalBuyBalance;
        }

        public double Sell()
        {
            TotalSellBalance += Product.PriceWhenSell;
            return TotalBuyBalance;
        }

        public double GetRevenue()
        {
            Revenue = TotalSellBalance - TotalBuyBalance;
            return Revenue;
        }

        public override string ToString()
        {
            return $"This Store revenue is {TotalSellBalance}, also the expenses are{TotalBuyBalance} " +
                $"\n Total Profit : {Revenue}";
        }
    }
}
