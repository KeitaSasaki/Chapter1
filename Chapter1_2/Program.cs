using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1_2 //1.2～1.5まで
{

    struct MyPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        //コンストラクタ
        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyPoint a = new MyPoint(10, 20);
            MyPoint b = a;
            Console.WriteLine("a;{0},{1}", a.X, a.Y);
            Console.WriteLine("b;{0},{1}", b.X, b.Y);
            a.X = 80;
            Console.WriteLine("--a.X = 80--");
            Console.WriteLine("a;{0},{1}", a.X, a.Y);
            Console.WriteLine("b;{0},{1}", b.X, b.Y);

            Action keep = () => Console.WriteLine("----------");  Console.ReadLine(); Console.ReadKey();
            keep();
        }
    }

    /*処理結果
     * 
     * --structの場合--
     *  a:10,20
     *  b:10,20
     * --a.X = 80;--
     *  a:80,20
     *  b:10,20
     * ----------
     * 
     * 
     * --class(参照型)の場合--
     * a:10,20
     * b:10,20
     * --a.X = 80;
     * a:80,20
     * b:80,20
     * ----------
     */

}
