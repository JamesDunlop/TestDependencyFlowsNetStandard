using System;
using TestDependencyFlows.Library;

namespace TestDependencyFlows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SomeService.GetSomething());
            Console.ReadKey();
        }
    }
}
