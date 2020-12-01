using System;

namespace RecursiveDrawing

{
    class Program
    {
        static void Main(string [ ] args)
        {
            RecDrawing( int.Parse( Console.ReadLine( ) ) );
        }


        static void RecDrawing(int n)
        {
            if ( n == 0 )
            {
                return;
            }
            else
            {
                Console.WriteLine(new string('*',n));
                RecDrawing( n - 1 );
                Console.WriteLine( new string( '#', n ) );
            }
        }
    }

}
