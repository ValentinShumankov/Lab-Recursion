using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int result =  RecursiveFibonachi( inputNum );
            Console.WriteLine(result);
        }

        private static int RecursiveFibonachi(int num )
        {
            if ( num == 0 )
            {
                return 0;
            }
            else
            {
                return RecursiveFibonachi( num - 1 ) + RecursiveFibonachi( num - 2 );
            }
            
        }
    }
}
