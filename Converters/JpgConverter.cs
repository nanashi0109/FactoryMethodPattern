using FactoryMethodPattern.Core;
using System;
using System.IO;

namespace FactoryMethodPattern.Converters
{
    public class JpgConverter : AImageConverter
    {
        public override void Convert(string source, string target)
        {
            FileInfo file = new FileInfo(source);

            if (file.Exists)
                file.CopyTo(Path.ChangeExtension(target, ".png"));
            else
                Console.WriteLine(Constants.FILE_NOT_EXISTS);
        }
    }
}