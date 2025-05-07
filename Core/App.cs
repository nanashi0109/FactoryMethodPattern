using FactoryMethodPattern.Converters;
using System;

namespace FactoryMethodPattern
{
    public class App
    {
        private AConverterCreator _converterCreator;

        public App(AConverterCreator converterCreator) 
            => _converterCreator = converterCreator;

        public void Start()
        {
            string sourceFile = GetUserSourceFile();
            string targetFile = GetUserTargetFile();

            AImageConverter converter = _converterCreator.Create();

            converter.Convert(sourceFile, targetFile);
        }

        private string GetUserTargetFile()
        {
            Console.Write("Путь исходнога файла");

            return Console.ReadLine();
        }

        private string GetUserSourceFile()
        {
            Console.Write("Путь целевого файла");

            return Console.ReadLine();
        }
    }
}