using System;

namespace hello_world
{
   internal class Program
    {
       private static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Program requires at least one argument");
                return;
            }

            Console.WriteLine(string.Format("Hello {0}!",args[0]));

            Console.ReadLine();
        }
    }
}
