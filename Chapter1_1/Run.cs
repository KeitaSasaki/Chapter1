using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1_1 //1.1
{
    class Run
    {
        public static void Main(String[] args)
        {
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福", 160);
            int price = karinto.Price;
            int taxInclude = karinto.GetPriceIncludeTax();        
            int price2 = daifuku.Price;
            int taxInclude2 = daifuku.GetPriceIncludeTax();

            Console.WriteLine("商品コード={0},商品名＝{1},商品価格＝{2}",karinto.Code,karinto.Name,taxInclude);
            Console.WriteLine("商品コード={0},商品名＝{1},商品価格＝{2}", daifuku.Code, daifuku.Name, taxInclude2);
            Action  keep = () => Console.ReadLine(); Console.ReadKey();
            keep();
        }
    }
}
