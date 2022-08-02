using System;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Num");
            int num = int.Parse(Console.ReadLine());
            for (int a = 1; a <= num; a++)
            {
                // for (int b = 0; b < num; b++)
                // {
                //     Console.Write(a);
                // }
                Console.Write(a + " ");
            }
        }
    }
}    
