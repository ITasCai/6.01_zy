using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 2.	使用委托实现两个数的加减乘除（Int类型）,并打印结果。 加减乘除方法要使用静态方法。

            //创建委托变量
            MathDelegation md;
            //把计算加法的方法赋值给委托变量
            md = MyMath.Add;
            Console.WriteLine(md(22,33));

            //把计算减法的方法赋值给委托变量
            md = MyMath.Subtract;
            Console.WriteLine(md(55, 33));

            Console.ReadKey();

            #endregion
        }
    }
}
