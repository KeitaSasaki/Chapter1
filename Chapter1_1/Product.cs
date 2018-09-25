using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1_1
{
    public class Product
    {
        //商品コード
        public int Code { get; private set; }
        //商品名
        public string Name { get; private set; }
        //商品価格
        public int Price { get; private set; }

        //コンストラクタ
        public Product(int code,string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }
        
        //消費税を求める
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        //税込み価格を求める
        public int GetPriceIncludeTax()
        {
            return Price + GetTax();
        }
    }
}
