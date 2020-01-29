using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnchangedClass unchangedClass = new UnchangedClass();
            Adapter adapter = new Adapter();

            unchangedClass.SomeMethod("asfasf");
            adapter.OtherMethod("asfasfsf");
            Console.ReadKey();
        }
    }
}
