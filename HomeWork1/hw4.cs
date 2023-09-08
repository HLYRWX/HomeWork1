namespace PrimeFactorizationF
{
    class Program
    {
        public static void Main(string[] args)
        {
            //用户输入一个数值
            Console.Write("请输入一个数值");
            int i = int.Parse(Console.ReadLine());
            //质因数最小从2开始
            int num = 2;
            //保存用户输入值不被改变
            int n = i;
            //标志第一个值
            int first = 1;
            while (num <= n)
            {
                //判断是否还可以被当前数整除
                if (!(i % num == 0))
                {
                    //不能再被前一个数整除
                    num++;
                }
                else
                {
                    //缩小当前倍数
                    i /= num;
                    //只执行一次
                    if (first == 1)
                    {
                        first = 0;
                        //输出第一个最小值
                        Console.Write(n + "=" + num);
                    }
                    else
                    {
                        //由小到大依次输出
                        Console.Write("*" + num);
                    }
                }
            }
            //产生换行
            Console.WriteLine();
        }
    }
}
