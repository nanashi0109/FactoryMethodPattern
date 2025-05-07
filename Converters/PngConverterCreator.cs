namespace FactoryMethodPattern.Converters
{
    public class PngConverterCreator : AConverterCreator
    {
        public override AImageConverter Create()
        {
            return new PngConverter();
        }
    }
}