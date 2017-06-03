using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一题
{
    class Program
    {
        static void Main(string[] args)
         {
            #region 1.	将中国人、美国人、德国人打招呼的方式用委托实现。
            Greetings g = new Greetings();
            GreetingsDelegation gd = g.Chinese;
            gd("狗蛋");
            GreetingsDelegation gd2 = g.American;
            gd2("奥巴马");
            GreetingsDelegation gd3 = g.German;
            gd3("希特勒");


            Console.ReadLine();
            #endregion
        }
    }
}
