using System;

namespace Chapter1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product karinto = new Product(123,"かりんとう",180);
            int price = karinto.Price;
            int TaxInclude = karinto.GetPriceIncludingTax();
            Console.WriteLine("商品コード:{0} 商品名:{1} 商品価格:{2}円 税込み価格:{3}円", karinto.Code, karinto.Name, karinto.Price,karinto.GetPriceIncludingTax());

            Product dorayaki = new Product(98, "どら焼き", 210);
            int price1 = dorayaki.Price;
            int TaxInclude2 = dorayaki.GetPriceIncludingTax();
            Console.WriteLine("商品コード:{0} 商品名:{1} 商品価格:{2}円 税込み価格:{3}円", dorayaki.Code, dorayaki.Name, dorayaki.Price, dorayaki.GetPriceIncludingTax());
            Action keep = () => Console.ReadLine(); Console.ReadKey();
            keep();
        }
    }

    class Product
    {

        //商品コード
        public int Code { get;private set; }
        //商品名
        public string Name { get; private set; }
        //商品価格税抜き
        public int Price { get; private set; }

        //コンストラクタ
        public Product(int code,string name,int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        //消費税額を求める
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        //税込み価格を求める
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}
