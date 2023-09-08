using System;
namespace ConsoleApplicationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1000以内的完数为：");
            int a;
            for (int i = 6; i <= 1000; i++)//6之前的数都不满足，降低计算量
            {
                string s = "1";
                a = 1;
                for (int j = 2; j <= i / 2; j++)//一个数的最大因数小于等于这个数的一半，减少计算量
                {
                    if (i % j == 0)
                    {
                        a += j;
                        s += "+" + j;
                    }
                }
                if (a == i)
                    Console.WriteLine(a + "=" + s);
            }
        }
    }
}