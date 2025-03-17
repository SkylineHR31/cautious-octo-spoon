namespace HW15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2),
            new Carrot(30)
        };

            VegetableShop shop = new VegetableShop();
            shop.AddProducts(products);

            shop.PrintProductsInfo();
        }
    }
}
