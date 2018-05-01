namespace Assets
{
    public abstract class AbstractFactory
    {
        public abstract int RegenerateHealthpoints { get; }
        public abstract AdditionalHealthFactory CreateHealthObject();
    }
}
