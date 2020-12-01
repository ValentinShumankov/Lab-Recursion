using System;

namespace Generating_1_Vectors
{
    class Program
    {
        static void Main(string [ ] args)
        {
            var array = new int[int.Parse(Console.ReadLine())];
            Gen01( 0, array );
        }
        
        static void Gen01(int index, int [ ] vector)
        {
            if ( index == vector.Length )
            {
                Print( vector );
            }
            else
            {
                for ( int i = 0; i <= 1; i++ )
                {
                    vector [ index ] = i;
                    Gen01( index + 1, vector );
                }
            }
        }
        static void Print(int [ ] nums)
        {
            Console.WriteLine( String.Join( "", nums ) );
        }
       
    }
}
