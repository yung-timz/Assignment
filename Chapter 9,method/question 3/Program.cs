using System;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a no");
            int a = int.Parse(Console.ReadLine());
            int b = a % 10;
            EnglishName(b);
        }
        public static void EnglishName(int num)
        {
            switch(num)
            {
                case 0 : 
                Console.WriteLine("Zero");
                break;

                case 1 :
                Console.WriteLine("one");
                break;

                case 2 :
                Console.WriteLine("two");
                break;

                case 3 :
                Console.WriteLine("three");
                break;
                
                case 4 :
                Console.WriteLine("four");
                break;
                
                case 5 :
                Console.WriteLine("five");
                break;
                
                case 6 :
                Console.WriteLine("six");
                break;
                
                case 7 :
                Console.WriteLine("seven");
                break;
                
                case 8 :
                Console.WriteLine("eight");
                break;
                
                case 9 :
                Console.WriteLine("nine");
                break;

                default :
                Console.WriteLine();
                break;
            }
        }

    }
}
