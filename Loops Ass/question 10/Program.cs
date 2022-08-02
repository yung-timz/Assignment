using System;

namespace question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n (n < 20)");
            int num = int.Parse(Console.ReadLine());      
            for (int a = 1; a <= num; a++)
            {
                for (int b = a; b <= a; b++) Console.Write("{0} ", b);
                Console.WriteLine();
            } 

        }
    }
}
