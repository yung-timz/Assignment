using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Num");
            int num = int.Parse(Console.ReadLine());
            for (int a = 1; a <= num; a++)
            {
                if (a % 3 == 0 && a % 7 == 0)
                {
                    continue;
                }            
                Console.Write(a + " ");   
            }

        }
    }
}
