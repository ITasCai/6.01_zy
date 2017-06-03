using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五题
{

 

    class Book
    {
        /// <summary>
        /// 出版社
        /// </summary>
        private string press;
       /// <summary>
       /// 书名
       /// </summary>
        private string mybook;

        /// <summary>
        /// 出版社
        /// </summary>
        public string Press
        {
            get
            {
                return press;
            }

            set
            {
                press = value;
            }
        }
        /// <summary>
        /// 书名
        /// </summary>
        public string Mybook
        {
            get
            {
                return mybook;
            }

            set
            {
                mybook = value;
            }
        }

        /// <summary>
        /// 构造方法，用于初始化数据
        /// </summary>
        /// <param name="press">出版社<param>
        /// <param name="mybook">书名</param>
        public Book(string press,string mybook) {
            this.press = press;
            this.mybook = mybook;
        }

        public Book() {
        }

        /// <summary>
        /// 用于信息的输出
        /// </summary>
        /// <param name="press">出版社</param>
        /// <param name="mybook">书名</param>
        public void GetBook(string press,string mybook) {
            Console.WriteLine(press+":"+mybook);
        }
    }
}
