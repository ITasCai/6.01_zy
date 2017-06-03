using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4.	使用Lambda表达式实现参数型数组(整型数组),返回所有数组元素之和，并将结果打印出来。

            int[] num = { 1,2,3,4,5,6,7};
            //定义委托变量，使用Lambda表达式
            ArraySumDelegation ad = (x) => {

                //存放数组元素之和
                int count = 0;
                //遍历数组元素
                for (int i = 0; i < x.Length; i++)
                {
                    //元素相加
                    count += x[i];
                }

                return count;
            };

             int nu= ad(num);
            Console.WriteLine(nu);

            Console.ReadKey();

            #endregion
        }
    }
}
