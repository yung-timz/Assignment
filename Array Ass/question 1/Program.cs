using System;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            for (int a = 0; a < arr.Length; a++)
            {
                arr[a] = a * 5;
                Console.WriteLine(arr[a]);
            }

        }
    }
}
