using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string [ ] args)
        {
            int result = Matematics.Sums(Console.ReadLine().Split().Select(int.Parse).ToArray(),0);
            Console.WriteLine(result);
        }
    }
    class Matematics
    {
        public static int Sums (int[] array, int index)
        {
            if ( index == array.Length )
            {
                return 0;
            }
            else
            {
                return array [ index ] + Sums( array, index+1 );
            }
        }
    }
}
