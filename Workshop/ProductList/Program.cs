using System;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.ProductName = "Iphone11 64 gb";
            Product1.ProductId = 541167;
            Product1.ProductCategoryId = 250369;
            Product1.ProductPrice = 7800;

            Product Product2 = new Product();
            Product2.ProductName = "Apple MacBook";
            Product2.ProductId = 625364;
            Product2.ProductCategoryId = 126879;
            Product2.ProductPrice = 11000;

            Product Product3 = new Product();
            Product3.ProductName = "Dyson V12 Şarjlı Süpürge";
            Product3.ProductId = 467298;
            Product3.ProductCategoryId = 250473;
            Product3.ProductPrice = 6038;

            Product[] Detail = new Product[] { Product1, Product2, Product3 };

            Console.WriteLine("ProductName"+" "+ "ProductId"+" "+"ProductCategoryId"+" "+"ProductPrice");

            //Foreach Döngüsü İle Gösterimi
            foreach (var ProductList in Detail)
            {
                Console.WriteLine(ProductList.ProductName + "  " + ProductList.ProductId + "  " +
                    ProductList.ProductCategoryId + "  " + ProductList.ProductPrice);
            }

            Console.WriteLine();

            //For Döngüsü İle Gösterimi
            for (int i = 0; i <Detail.Length ; i++)
            {
                Console.WriteLine(Detail[i].ProductName + " " + Detail[i].ProductId + " "+ 
                    Detail[i].ProductCategoryId + " " + Detail[i].ProductPrice);
            }

            Console.WriteLine();

           //While Döngüsü İle Gösterimi
            var j = 0;
            while (j<Detail.Length)
            {
                Console.WriteLine(Detail[j].ProductName + " " + Detail[j].ProductId + " " +
                    Detail[j].ProductCategoryId + " " + Detail[j].ProductPrice);
                j++;
            }

        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
