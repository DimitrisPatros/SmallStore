using System;

namespace SmallStore
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create new Simple Store
            var GalleryDePate = new SimpleStore();

            // Creation of Products 
            var x1 = new Product(1, "Painting Picasso. Guernica", 100, 1000);
            var x2 = new Product(2, "Painting Tsarouxis. Naftis A", 200, 2000);
            var x4 = new Product(3, "Chair. Luis XV", 100, 1000);
            var x5 = new Product(4, "Vase. Cubic", 500, 5000);

            //Samples transactions

            GalleryDePate.Buy(x1.PriceWhenBuy);
            GalleryDePate.Buy(x2.PriceWhenBuy);
            Console.WriteLine(GalleryDePate.GetRevenue());

        }
    }
}
