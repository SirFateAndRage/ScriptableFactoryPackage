using ScriptableFactoryPackage.WrappedObjectConfiguration;
using ScriptableFactoryPackage.Factory;
using UnityEngine;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    [CreateAssetMenu(menuName = "CustomFactory/ConsumerConfiguration/WrappedConsumerConfiguration")]
    public class WrappedConsumerConfiguration<TObject, TId, TWrapperObject> : ConsumerConfiguration<TObject, TId, TWrapperObject>
    where TWrapperObject : WrappedObjectConfiguration<TObject, TId>
    {
        protected override IFactory<TObject, TId, TWrapperObject> GetInitializeFactory(FactoryConfiguration<TObject, TId, TWrapperObject> factoryConfiguration) => new WrappedFactory<TObject, TId, TWrapperObject>(factoryConfiguration);
    }
}