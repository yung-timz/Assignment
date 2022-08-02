using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 1st num");
            int nu1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd num");
            int nu2 = int.Parse(Console.ReadLine());
            GetMax(nu1,nu2);
        }
        public static void GetMax(int num1,int num2)
        {
            if(num2>num1)
            {
                Console.WriteLine($"the largest of the 2 numbers is {num2}");
            }
            else if(num1>num2)
            {
                Console.WriteLine($"the largest of the 2 numbers is {num1}");
            }
            else
            {
                Console.WriteLine($"the largest of the 2 numbers is {num1}");
            }
            Console.WriteLine("enter first num");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter third num");
            int c = int.Parse(Console.ReadLine());
            int largest = 0;
            if(a != b)
            {
                if(a > b)
                {
                    largest = a;
                }
                else if(b > a)
                {
                    largest = b;
                }
                else
                {
                    largest = a;
                }
            }
            if(largest != c)
            {   
                if(largest > c)
                Console.WriteLine($"the largest num is, {largest}");
                else if(c > largest)
                {
                    largest = c;
                    Console.WriteLine($"the largest num is, {largest}");
                }
            }
            else
            {
                Console.WriteLine($"they are equal");
            }
        }
    }
}
