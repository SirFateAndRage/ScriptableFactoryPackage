using ScriptableFactoryPackage.WrappedObjectConfiguration;
using ScriptableFactoryPackage.FactoryObject;

namespace ScriptableFactoryPackage.Factory
{
    public class WrappedFactory<TObject, TId, TWrappingObject> : Factory<TObject, TId, TWrappingObject>
    where TWrappingObject : IIdentifator<TId>, IWrapper<TObject>
    {
        public WrappedFactory(FactoryConfiguration<TObject, TId, TWrappingObject> factoryConfiguration) : base(factoryConfiguration)
        {
        }

        protected override TObject GetObject(TId id, FactoryConfiguration<TObject, TId, TWrappingObject> factoryConfiguration) =>factoryConfiguration.GetFactoryObjectById(id);
    }

}
