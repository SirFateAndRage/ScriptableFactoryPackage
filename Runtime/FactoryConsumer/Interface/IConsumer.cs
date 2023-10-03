namespace ScriptableFactoryPackage.FactoryConsumer
{
    public interface IConsumer<TId>
    {
        void ConsumeFactoryObject(TId id);
    }
}