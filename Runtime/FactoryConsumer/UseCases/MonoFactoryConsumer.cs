using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryObject;
using UnityEngine;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    public class MonoFactoryConsumer<TObject, TId> : FactoryConsumer<MonoFactory<TObject, TId>, TObject, TId, TObject>
    where TObject : MonoBehaviour, IIdentifator<TId>
    {
        public override void ConsumeFactoryObject(TId id) { }
    }
}