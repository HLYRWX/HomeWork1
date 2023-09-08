using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要判断的数：");
            int j = 0;                                                                                           //用来记录开方之后的最大数
            int num = Convert.ToInt32(Console.ReadLine());
            j = (int)Math.Ceiling(Math.Sqrt(Convert.ToDouble(num)));
            int k = 0;                                                                                          //记录余数
            for (int i = 2; i <= j; i++)
            {
                k = Convert.ToInt32(Math.IEEERemainder(num, i));                    //求余并记录
            }
            if (k == 0)                                                                                            //判断余数是否为0
                Console.WriteLine(num + "不是素数");
            else
                Console.WriteLine(num + "是素数");
            Console.ReadKey();
        }
    }
}