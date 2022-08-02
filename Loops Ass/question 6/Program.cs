using System;

namespace question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n (1<K<N)");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("enter k (1<K<N)");
            int k =int.Parse(Console.ReadLine());          
            for (int a = n - 1; a > 0; a--) n *= a;
            for (int a = k - 1; a > 0; a--) k *= a;
            n /= k;    
            Console.WriteLine("Result is {0}", n);

        }
    }
}
