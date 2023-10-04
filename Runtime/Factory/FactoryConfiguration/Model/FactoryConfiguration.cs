using ScriptableFactoryPackage.FactoryObject;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableFactoryPackage.Factory
{
    public abstract class FactoryConfiguration<TObject, TId, TWrapperObject> : ScriptableObject where TWrapperObject : IIdentifator<TId>
    {
        [SerializeField] private TWrapperObject[] _wrapperObjects;

        private Dictionary<TId, TObject> _idToFactoryObject;

        protected abstract void SetInitialConfiguration(TWrapperObject[] factoryObjects, Dictionary<TId, TObject> idToFactoryObject);

        public void InitConfiguration()
        {
            _idToFactoryObject = new Dictionary<TId, TObject>();

            SetInitialConfiguration(_wrapperObjects, _idToFactoryObject);
        }

        public TObject GetFactoryObjectById(TId id)
        {
            if (!_idToFactoryObject.TryGetValue(id, out TObject factoryObject))
                throw new Exception("Error on DictionaryFactory: There isn't a product with id " + id);

            return factoryObject;
        }
    }
}