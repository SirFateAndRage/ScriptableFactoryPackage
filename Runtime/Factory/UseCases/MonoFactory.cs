using ScriptableFactoryPackage.FactoryObject;
using UnityEngine;

namespace ScriptableFactoryPackage.Factory
{
    public class MonoFactory<TObject, TId> : Factory<TObject, TId, TObject>
    where TObject : MonoBehaviour, IIdentifator<TId>
    {
        public MonoFactory(FactoryConfiguration<TObject, TId, TObject> factoryConfiguration) : base(factoryConfiguration)
        {
        }

        protected override TObject GetObject(TId id, FactoryConfiguration<TObject, TId, TObject> factoryConfiguration)
        {
            TObject factoryObject = factoryConfiguration.GetFactoryObjectById(id);

            return Object.Instantiate(factoryObject);
        }
    }
}