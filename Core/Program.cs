using System;

namespace FactoryMethodPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            App app = new App();

            app.Start();

            Console.ReadKey();
        }
    }
}