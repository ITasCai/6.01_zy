using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    /// <summary>
    /// 自定义委托，用于对数组的操作
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public delegate string ArrayDelegation(string str);
    class MyArray
    {

        /// <summary>
        /// 对数组中的元素进行遍历
        /// </summary>
        /// <param name="array"></param>
        /// <param name="ad"></param>
        public void GetArray(string[]array,ArrayDelegation ad) {
            for (int i = 0; i <array.Length; i++)
            {
                array[i] = ad(array[i]);
            }
        }

        /// <summary>
        /// 将元素转换为小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string LowerCase(string str) {
            return str.ToLower();
        }

        /// <summary>
        /// 将元素转换为大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Upper(string str)
        {
            return str.ToUpper();
        }

    }
}
