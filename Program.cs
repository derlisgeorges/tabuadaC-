using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int e = 1; e <= 10; e ++)
           {
               for( int d = 1; d<=10; d++)
               {
                   Console.WriteLine(e + "X" + d + " = " + e * d);
               }
               Console.WriteLine();
           }
        }

    }
}
