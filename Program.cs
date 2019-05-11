using System;

namespace SmallStore
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new Simple Store
            IStore galleryDePate = new SimpleStore();
            
            // Creation of Products 
            Product x1 = new Product(1, "Painting Picasso. Guernica", 100, 1000);
            Product x2 = new Product(2, "Painting Tsarouxis. Naftis A", 200, 2000);
            Product x3 = new Product(3, "Chair. Luis XV", 100, 1000);
            Product x4 = new Product(4, "Vase. Cubic", 500, 5000);

            //Samples transactions
            galleryDePate.Buy(x1); galleryDePate.Buy(x3); galleryDePate.Sell(x1);
            Console.WriteLine(galleryDePate.GetRevenue());




            InventoryRetailStore invStore = new InventoryRetailStore();
            invStore.Buy(x1); invStore.Buy(x3); invStore.Sell(x1);
            Console.WriteLine(invStore.GetRevenue());
            invStore.Sell(x2);
            invStore.GetInventory();
            Console.WriteLine(invStore.GetRevenue());

            Console.ReadKey();


        }
    }
}
