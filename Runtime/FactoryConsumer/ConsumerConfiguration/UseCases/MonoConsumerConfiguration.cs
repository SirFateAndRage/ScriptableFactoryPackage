using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryObject;
using UnityEngine;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    [CreateAssetMenu(fileName = "Default" ,menuName = "CustomFactory/ConsumerConfiguration/MonoConsumerConfiguration/Default", order = -1)]
    public class MonoConsumerConfiguration<TObject, TId> : ConsumerConfiguration<TObject, TId, TObject>
    where TObject : MonoBehaviour, IIdentifator<TId>
    {
        protected override IFactory<TObject, TId, TObject> GetInitializeFactory(FactoryConfiguration<TObject, TId, TObject> factoryConfiguration) => new MonoFactory<TObject, TId>(factoryConfiguration);
    }
}