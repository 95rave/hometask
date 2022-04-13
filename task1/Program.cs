using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pieces = 0;
            pieces = int.Parse(Console.ReadLine());
            if (pieces % 2 == 0)
                Console.WriteLine(pieces+ "is a double");
            else
                Console.WriteLine(pieces+ "is a sinle");
             
           
          
        }
    }
}
