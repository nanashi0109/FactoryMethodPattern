using FactoryMethodPattern.Core;
using System;
using System.IO;

namespace FactoryMethodPattern.Converters
{
    public class PngConverter : AImageConverter
    {
        public override void Convert(string source, string target)
        {
            FileInfo file = new FileInfo(source);

            if (file.Exists)
                file.CopyTo(Path.ChangeExtension(target, ".jpg"));
            else
                Console.WriteLine(Constants.FILE_NOT_EXISTS);
        }
    }
}