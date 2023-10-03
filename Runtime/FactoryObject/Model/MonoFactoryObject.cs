using UnityEngine;

namespace ScriptableFactoryPackage.FactoryObject
{
    public abstract class MonoFactoryObject<TId> : MonoBehaviour, IIdentifator<TId>
    {
        [SerializeField] private TId _id;
        public TId Id => _id;
    }
}