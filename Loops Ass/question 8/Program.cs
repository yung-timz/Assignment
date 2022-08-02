using System;

namespace question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n (n >=0 )");
            int n =int.Parse(Console.ReadLine());
            int factN = 2 * n;
            int factPlus = n + 1;
            for (int a = factN - 1; a > 0; a--) factN *= a;
            for (int a = factPlus - 1; a > 0; a--) factPlus *= a;
            for (int a = n - 1; a > 0; a--) n *= a;

            Console.WriteLine("Result is {0}", factN / (factPlus * n));

        }
    }
}
