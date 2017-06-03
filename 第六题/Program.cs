using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6.	小明每次买书，直接给书店店主说明 图书名称、图书单价、图书数量，然后要求书店直接送到家里现金支付，使用Func模拟过程。
            //实例化
            Book b = new Book();
            // Func是有返回值的泛型委托
            Func<string, double, int, string> f = new Func<string, double, int, string>(b.Show);
           //赋值输出 
            Console.WriteLine(f(".net基础", 45, 2));

            Console.ReadKey();

            #endregion
        }
    }
}
