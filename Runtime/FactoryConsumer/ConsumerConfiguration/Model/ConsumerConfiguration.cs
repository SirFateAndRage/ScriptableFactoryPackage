using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryObject;
using UnityEngine;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    [CreateAssetMenu(menuName = "CustomFactory/ConsumerConfiguration")]
    public abstract class ConsumerConfiguration<TObject, TId, TWrapperObject> : ScriptableObject
    where TWrapperObject : IIdentifator<TId>
    {
        [SerializeField] private FactoryConfiguration<TObject, TId, TWrapperObject> _factoryConfiguration;

        protected abstract IFactory<TObject, TId, TWrapperObject> GetInitializeFactory(FactoryConfiguration<TObject, TId, TWrapperObject> factoryConfiguration);

        public IFactory<TObject, TId, TWrapperObject> GetFactory()
        {
            _factoryConfiguration.InitConfiguration();

            return GetInitializeFactory(_factoryConfiguration);
        }
    }
}