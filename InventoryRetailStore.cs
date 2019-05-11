using System;
using System.Collections.Generic;
using System.Linq;


namespace SmallStore {
    class InventoryRetailStore : IStore {
        public InventoryRetailStore() {
            Inventory = new List<Product>();
            SoldProducts = new List<Product>();
        }
       
        private List<Product> Inventory { get; set; }
        private List<Product> SoldProducts { get; set; }

        public void Buy(Product product) {
            Inventory.Add(product);
        }


        public void Sell(Product product) {
            bool removedProduct = Inventory.Remove(product);

            if (!removedProduct) {
                Console.WriteLine("there is no such product in the inventory");
            } else {
                SoldProducts.Add(product);
            }
        }

        public double GetRevenue() {
            double inventoryValue = Inventory.Sum(p => p.PriceWhenBuy);
            double soldItemsNetProfit = SoldProducts.Sum(p => p.PriceWhenSell - p.PriceWhenBuy);
            return soldItemsNetProfit - inventoryValue;
        }

        public void GetInventory() {
            foreach (Product p in Inventory) {
                Console.WriteLine(p);
            }
        }

        public void Reset() {
            Inventory = SoldProducts = new List<Product>();
        }
    }
}
