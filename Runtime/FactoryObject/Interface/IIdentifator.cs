namespace ScriptableFactoryPackage.FactoryObject
{
    public interface IIdentifator<TId>
    {
        public TId Id { get; }
    }
}