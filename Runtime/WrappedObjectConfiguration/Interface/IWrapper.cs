namespace ScriptableFactoryPackage.WrappedObjectConfiguration
{
    public interface IWrapper<TObject>
    {
        TObject GetObject();
    }
}