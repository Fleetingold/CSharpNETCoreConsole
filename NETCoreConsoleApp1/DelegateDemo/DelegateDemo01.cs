using System;

delegate int NumberChanger(int n);
namespace DelegateAppl
{
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        //static void Main(string[] args)
        //{
        //    // 创建委托实例
        //    NumberChanger nc1 = new NumberChanger(AddNum);
        //    NumberChanger nc2 = new NumberChanger(MultNum);
        //    // 使用委托对象调用方法
        //    nc1(25);
        //    Console.WriteLine("Value of Num: {0}", getNum());
        //    nc2(5);
        //    Console.WriteLine("Value of Num: {0}", getNum());
        //    Console.ReadKey();
        //}

        //static void Main(string[] args)
        //{
        //    // 创建委托实例
        //    NumberChanger nc;
        //    NumberChanger nc1 = new NumberChanger(AddNum);
        //    NumberChanger nc2 = new NumberChanger(MultNum);
        //    nc = nc1;
        //    // 委托的多播：委托加委托
        //    //nc += nc2;
        //    //nc = nc + nc2;

        //    // 委托的多播：委托加方法
        //    //nc += TestDelegate.MultNum;
        //    //nc += TestDelegate.AddNum;

        //    // 委托的多播：从委托的方法列表中移除某方法
        //    //nc -= nc2;
        //    //nc = nc - nc2;
        //    // 调用多播
        //    nc(5);
        //    Console.WriteLine("Value of Num: {0}", getNum());
        //    Console.ReadKey();
        //}

    }
}