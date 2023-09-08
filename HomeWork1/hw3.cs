using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 水仙花数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int b;//百位
            int s;//十位
            int g;//个位
            int sum = 0;
            for (i = 100; i <= 999; i++)//用for循环依次遍历100到999中的所有数 
            {
                b = i / 100;//获取百位数
                s = i % 100 / 10;//获取十位数
                g = i % 10;//获取个位数
                sum = b * b * b + s * s * s + g * g * g;
                if (sum == i)
                {         //判断水鲜花数
                    Console.WriteLine("水仙花数有：" + i);
                }
            }
            Console.ReadLine();
        }
    }
}