using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二题
{
    /// <summary>
    /// 自定义委托，用于算数运算
    /// </summary>
    /// <param name="num1">参数1</param>
    /// <param name="num2">参数2</param>
    /// <returns></returns>
    public delegate int MathDelegation(int num1,int num2);
    class MyMath
    {

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="num1">参数1</param>
        /// <param name="num2">参数2</param>
        /// <returns></returns>
        public static int Add(int num1, int num2) {
            return num1 + num2;
        }

        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="num1">参数1</param>
        /// <param name="num2">参数2</param>
        /// <returns></returns>
        public static int Subtract(int num1,int num2) {
            return num1 - num2;
        }

        /// <summary>
        /// 用于存放方法
        /// </summary>
        /// <param name="num1">参数1</param>
        /// <param name="num2">参数2</param>
        /// <param name="md">委托</param>
        /// <returns></returns>
        public int NewMath(int num1, int num2,MathDelegation md) {
            return md(num1,num2);
        }
    }
}
