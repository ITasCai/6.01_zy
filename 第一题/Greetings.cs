using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一题
{
    /// <summary>
    /// 自定义委托，用于存放打招呼的方法
    /// </summary>
    public delegate void GreetingsDelegation(string name);

    class Greetings
    {

        /// <summary>
        /// 姓名
        /// </summary>
        private string name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        /// <summary>
        /// 用于存放打招呼的方法
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="gd">委托变量</param>
        public void entrust(string name, GreetingsDelegation gd) {
            gd(name);
        }


        /// <summary>
        /// 用于初始化数据
        /// </summary>
        /// <param name="name">姓名</param>
        public Greetings(string name) {
            this.name = name;
        }

        public Greetings() {
        }

        /// <summary>
        /// 中国人
        /// </summary>
        /// <param name="name">姓名</param>
        public void Chinese(string name) {
            Console.WriteLine(name+"：中国人");
        }

        /// <summary>
        /// 美国人
        /// </summary>
        /// <param name="name">姓名</param>
        public void American(string name) {
            Console.WriteLine(name+":美国人");
        }

        /// <summary>
        /// 德国人
        /// </summary>
        /// <param name="name"></param>
        public void German(string name) {
            Console.WriteLine(name+":德国人");
        }
    }
}
