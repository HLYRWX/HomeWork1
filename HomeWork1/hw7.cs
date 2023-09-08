using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            int chNum = 0, ChNum = 0, Num = 0, otherNum = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] <= '9' && ch[i] >= '0')
                    Num++;
                else if (ch[i] <= 'z' && ch[i] >= 'a')
                    chNum++;
                else if (ch[i] <= 'Z' && ch[i] >= 'A')
                    ChNum++;
                else
                    otherNum++;

            }
            Console.WriteLine("大写字母有：{0}", ChNum);
            Console.WriteLine("小写字母有：{0}", chNum);
            Console.WriteLine("数字有：{0}", Num);
            Console.WriteLine("其它字符有：{0}", otherNum);
            Console.ReadKey();
        }
    }
}