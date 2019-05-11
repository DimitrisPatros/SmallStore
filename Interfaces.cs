using System;
using System.Collections.Generic;
using System.Text;

namespace SmallStore
{
    public interface IStore
    {
        double Buy(double price);
        double Sell();
        double GetRevenue();
    }
}
