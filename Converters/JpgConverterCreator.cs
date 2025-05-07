namespace FactoryMethodPattern.Converters
{
    public class JpgConverterCreator : AConverterCreator
    {
        public override AImageConverter CreateConverter()
        {
            return new JpgConverter();
        }
    }
}