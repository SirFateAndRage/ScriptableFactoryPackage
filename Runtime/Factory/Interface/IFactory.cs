namespace ScriptableFactoryPackage.Factory
{
    public interface IFactory<TObject, TId, TWrappingObject>
    {
        public TObject GetObject(TId id);
    }
}