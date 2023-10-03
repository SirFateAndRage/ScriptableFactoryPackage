using ScriptableFactoryPackage.WrappedObjectConfiguration;
using ScriptableFactoryPackage.Factory;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    public class WrappedFactoryConsumer<TObject, TId> : FactoryConsumer<WrappedFactory<TObject, TId, WrappedObjectConfiguration<TObject, TId>>, TObject, TId, WrappedObjectConfiguration<TObject, TId>>
    {
        public override void ConsumeFactoryObject(TId id) { }
    }
}