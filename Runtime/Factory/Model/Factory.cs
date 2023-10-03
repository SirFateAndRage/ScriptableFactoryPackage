using ScriptableFactoryPackage.FactoryObject;

namespace ScriptableFactoryPackage.Factory
{
    public abstract class Factory<TObject, TId, TWrappingObject> : IFactory<TObject, TId, TWrappingObject> where TWrappingObject : IIdentifator<TId>
    {
        private readonly FactoryConfiguration<TObject, TId, TWrappingObject> _factoryConfiguration;

        protected Factory(FactoryConfiguration<TObject, TId, TWrappingObject> factoryConfiguration)
        {
            _factoryConfiguration = factoryConfiguration;
        }

        public TObject GetObject(TId id) => GetObject(id, _factoryConfiguration);
        protected abstract TObject GetObject(TId id, FactoryConfiguration<TObject, TId, TWrappingObject> factoryConfiguration);
    }
}