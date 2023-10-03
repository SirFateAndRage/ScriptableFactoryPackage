using ScriptableFactoryPackage.FactoryObject;
using UnityEngine;

namespace ScriptableFactoryPackage.WrappedObjectConfiguration
{
    [CreateAssetMenu(menuName = "CustomFactory/Configuration/WrappedObjectsConfiguration")]
    public abstract class WrappedObjectConfiguration<TObject, TId> : ScriptableObject, IIdentifator<TId>, IWrapper<TObject>
    {
        [SerializeField] private TId _id;
        public TId Id => _id;

        public abstract TObject GetObject();
    }
}