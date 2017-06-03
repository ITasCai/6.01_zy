using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3.	使用委托将,数组中的元素转化为大写，使用委托将数组元素转化为小写。

            string[] arrayName = {"ZhangSan","LiSi","WangWu","ZhaoLiu"};
            // 创建MyArray类的实例
            MyArray ma = new MyArray();
            //把数组中的元素转换为小写
            ma.GetArray(arrayName,ma.LowerCase);
            //遍历数组
            foreach (string item in arrayName)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("------------------------------");
            //将数组中的元素转换为大写
            ma.GetArray(arrayName, ma.Upper);
            //遍历数组
            foreach (string item in arrayName)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();

            #endregion
        }
    }
}
