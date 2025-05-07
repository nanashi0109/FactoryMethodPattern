using FactoryMethodPattern.Converters;
using FactoryMethodPattern.Core;
using System;

namespace FactoryMethodPattern
{
    public class Program
    {

        static void Main(string[] args)
        {
            App app = new App(GetConverter());

            app.Start();

            Console.ReadKey();
        }

        private static AConverterCreator GetConverter()
        {
            Console.Write(Constants.TARGET_FORMAT);

            string userData = Console.ReadLine();

            AConverterCreator converter = null;

            switch(userData.ToLower())
            {
                case "jpg":
                    converter = new PngConverterCreator();
                    break;
                case "png":
                    converter = new JpgConverterCreator();
                    break;
            }

            return converter;   
        }
    }
}