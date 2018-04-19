using System;
using System.Collections.Generic;

namespace UseNetFrameworkWithNetCore.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this .NET Core Console App");

            int[] array = new[] { 1, 4, 3, 2 };

            List<int> set = new List<int>(array);
            //OrderedSet<int> set = new OrderedSet<int>()

            set.ForEach(item => Console.WriteLine(item));

            Console.WriteLine("Finished the .NET Core Console App");
            Console.ReadLine();
        }
    }
}
