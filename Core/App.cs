using FactoryMethodPattern.Converters;
using FactoryMethodPattern.Core;
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

            Console.WriteLine(Constants.SUCCESS_CONVERTING);
        }

        private string GetUserTargetFile()
        {
            Console.Write(Constants.TARGET_FILE_PATH);

            return Console.ReadLine();
        }

        private string GetUserSourceFile()
        {
            Console.Write(Constants.SOURCE_FILE_PATH);

            return Console.ReadLine();
        }
    }
}