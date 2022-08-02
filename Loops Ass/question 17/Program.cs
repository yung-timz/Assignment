using System;

namespace question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = int.Parse(Console.ReadLine());
            
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }
            
            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);

        }
    }
}
