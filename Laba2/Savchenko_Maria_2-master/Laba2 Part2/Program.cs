using Laba2_Part2.Models.Goods;
using Laba2_Part2.Models.Shop;
using System;


namespace Laba2_Part2 {
    class Program {
        static void Main(string[] args) {
            Shop shop = new Shop("ATB");
            Stamp MadeToday = new Stamp() {
                Expires = DateTime.Now.AddDays(14),
                Made = DateTime.Now
            }, Expired = new Stamp() {
                Expires = DateTime.Now,
                Made = DateTime.Now.AddDays(-14)
            }, invulnerable = new Stamp() {
                Expires = DateTime.Now.AddDays(1),
                Made = new DateTime(2020, 1, 1)
            };
            
            Milk[] milk = new Milk[] {
                new Milk("Classic Milk RedBlue", 22.50M, "Rud", MadeToday, 3.2M),
                new Milk("Fat Milk RedBlue", 25.30M, "Rud", invulnerable, 4.5M),
                new Milk("Classic Milk RedBlue", 22.50M, "Rud", Expired, 3.2M),
                new Milk("Fat Milk RedBlue", 25.30M, "Rud", Expired, 4.5M),
                new Milk("Classic Milk RedBlue", 22.50M, "Rud", MadeToday, 3.2M),
            };
            Bread[] bread = new Bread[] {
                new Bread("Molochnyi", 15.80M, "Kyiv Bread Zavod", MadeToday, BreadType.White),
                new Bread("Classic", 16.80M, "Kyiv Bread Zavod", MadeToday, BreadType.Black),
                new Bread("French", 16.80M, "Kyiv Bread Zavod", MadeToday, BreadType.Baget),
                new Bread("Molochnyi", 15.80M, "Kyiv Bread Zavod", Expired, BreadType.White),
                new Bread("Classic", 16.80M, "Kyiv Bread Zavod", invulnerable, BreadType.Black),
                new Bread("French", 16.80M, "Kyiv Bread Zavod", Expired, BreadType.Baget),
            };
            shop.Supply(milk);
            shop.Supply(bread);
            Console.WriteLine("Products in the shop: ");
            shop.PrintGoods();
            Console.WriteLine("----------------------");
            Console.WriteLine("Expired products: ");
            foreach (var item in shop.FindRemoveExpired()) {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Shop after clean: ");
            shop.PrintGoods();
            Console.WriteLine("----------------------");
            Console.WriteLine("Products made in January: ");
            foreach (var item in shop.FindMadeBetween(new DateTime(2020, 1, 1), new DateTime(2020, 1, 30))) {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
