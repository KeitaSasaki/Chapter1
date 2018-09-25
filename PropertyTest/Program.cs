using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTest //プロパティの動作(?)確認
{
    class PropertyTest
    {
        private int num;

        
        public int Num
        {
            get { return num; }
            set { num = value + 1; }
        }
        
        
    }

    public class Test
    {
        public static void Main(String[] args)
        {
            var property = new PropertyTest();
            property.Num = 10;
            Console.WriteLine(property.Num);
            Action keep = () => Console.ReadLine(); Console.ReadKey();
            keep();
        }
    }
}
