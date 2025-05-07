namespace FactoryMethodPattern.Converters
{
    public class JpgConverterCreator : AConverterCreator
    {
        public override AImageConverter Create()
        {
            return new JpgConverter();
        }
    }
}