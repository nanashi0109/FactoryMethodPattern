namespace FactoryMethodPattern.Converters
{
    public class PngConverterCreator : AConverterCreator
    {
        public override AImageConverter CreateConverter()
        {
            return new PngConverter();
        }
    }
}