using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{

    public
    class Book
    {
        /// <summary>
        /// 书名
        /// </summary>
        private string bookName;
        /// <summary>
        /// 价格
        /// </summary>
        private double price;
        /// <summary>
        /// 数量
        /// </summary>
        private int count;


        /// <summary>
        /// 书名
        /// </summary>
        public string BookName
        {
            get
            {
                return bookName;
            }

            set
            {
                bookName = value;
            }
        }

        /// <summary>
        /// 价格
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="price"></param>
        /// <param name="count"></param>
        public Book(string bookName, double price, int count) {
            this.bookName = bookName;
            this.price = price;
            this.count = count;
        }

        public Book() {
        }


        public string Show(string bookName, double price, int count) {
            return "书名：" + bookName + "\t单价：" + price + "\t数量：" + count + "\t价格：" + price * count;
        }
        
    }
}
