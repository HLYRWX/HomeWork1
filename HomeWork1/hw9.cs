using System;

using System.Collections.Generic;

using System.Text;

namespace IronBall

{

    public class IronBall

    {

        public double hight = 0;

        //h是高度,count是反弹次数

        public double getDistance(double h, int count)

        {

            double dis = h;

            this.hight = h;

            for (int i = 0; i
            
{

                hight = hight / 2;

                dis += 2 * hight;

            }

            return dis;

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            IronBall rb = new IronBall();

            Console.WriteLine("总距离" + rb.getDistance(100, 10));

            Console.WriteLine("最后一次反弹高度" + rb.hight / 2);

            Console.ReadLine();

        }

    }

}