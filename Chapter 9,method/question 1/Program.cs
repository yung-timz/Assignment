using System;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a name");
            string oruko = Console.ReadLine();
            PrintName(oruko);
        }
        public static void PrintName(string oruko)
        {
            Console.WriteLine($"\"HELLO, {oruko}!\"");
        }
    }

}