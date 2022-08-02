
using System;

namespace Chapter_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("enter a number");
            // int a = int.Parse(Console.ReadLine());
            
            int[] array = {1,2,1,3,4,1,2};
            Console.WriteLine(CheckNumber(1,array));
        }

        public  static int CheckNumber(int a, int[] arr)
        {
                int count = 0;
                for(int i = 0; i <= arr.Length; i++)
                {
                    if(arr[i] == a)
                    {
                        count++;
                        break;
                    }
                }
                return count;
        }
        

        
    }
}