namespace ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());/*最大公约数和最小公倍数*/
            int n = Convert.ToInt32(Console.ReadLine());/*m*n=最大公约数*最小公倍数*/
            int t = n < m ? m : n;
            int t2 = 1;
            while (t > 1)
            {
                if ((m % t == 0) && (n % t == 0))
                {
                    Console.WriteLine("最大公约数" + t);
                    break;
                }
                t--;
            }
            Console.WriteLine("最小公倍数" + (m * n) / t);
        }
    }
}
