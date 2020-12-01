using System;

namespace _04_Recursive_Factorial
{
    class Program
    {
        
        static void Main(string [ ] args)
        {
            Console.WriteLine(RecFactorial(int.Parse(Console.ReadLine())));
        }
        public static int RecFactorial(int num)
        {
            if ( num == 1 )
            {
                return num;
            }
            else
            {
                return num * RecFactorial( num - 1 );
            }
        }
    }
}
