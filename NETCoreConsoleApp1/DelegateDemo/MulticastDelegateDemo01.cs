using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateAppl
{
    // 委托多播实例：例如小明叫小张买完车票，之后接着又让他带张电影票
    class MulticastDelegateDemo01
    {
        // 小张类
        public class MrZhang
        {
            // 其实买车票的悲情人物是小张
            public static void BuyTicket()
            {
                Console.WriteLine("NND,每次都让我去买票，急人呀！");
            }

            public static void BuyMovieTicket()
            {
                Console.WriteLine("我去，自己泡妞，还要让我带电影票！");
            }
        }

        //小明类
        class MrMing
        {
            // 声明一个委托，其实就是个“命令”
            public delegate void BuyTicketEventHandler();

            //public static void Main(string[] args)
            //{
            //    // 这里就是具体阐述这个命令是干什么的，本例是MrZhang.BuyTicket“小张买车票”
            //    BuyTicketEventHandler myDelegate = new BuyTicketEventHandler(MrZhang.BuyTicket);

            //    myDelegate += MrZhang.BuyMovieTicket;
            //    // 这时候委托被附上了具体的方法
            //    myDelegate();
            //    Console.ReadKey();
            //}
        }
    }
}
