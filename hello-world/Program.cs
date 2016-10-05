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
                Console.ReadLine();
                return;
            }

            var module = new hello_world_module();
            var module1 = new CapitalizeHello();


            Console.WriteLine(module1.Lower(module.SayHello(args[0])));

            Console.ReadLine();
        }
    }
}
