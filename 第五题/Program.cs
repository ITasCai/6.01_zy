using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5.	小明经常去买关于.NET开发方向的书籍，同时需要选择出版社，使用Action委托实现这一过程。
            //实例化
            Book b = new Book();
            //Action是无返回值的泛型委托,参数为string类型
            Action<string, string> act = new Action<string, string>(b.GetBook);
            act("清华大学出版社",".net基础");
            act("机械工程出版社", ".net从入门到放弃");

            Console.ReadKey();

            #endregion
        }
    }
}
