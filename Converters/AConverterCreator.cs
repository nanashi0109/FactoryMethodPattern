namespace FactoryMethodPattern.Converters
{
    public abstract class AConverterCreator
    {
        public abstract AImageConverter CreateConverter();
    }
}