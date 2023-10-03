using ScriptableFactoryPackage.WrappedObjectConfiguration;
using ScriptableFactoryPackage.FactoryObject;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableFactoryPackage.Factory
{
    [CreateAssetMenu(menuName = "CustomFactory/Configuration/WrappedFactoryConfigurations")]
    public class WrappedFactoryConfiguration<TObject, TId, TWrappingObject> : FactoryConfiguration<TObject, TId, TWrappingObject>
    where TWrappingObject : IIdentifator<TId>, IWrapper<TObject>
    {
        protected override void SetInitialConfiguration(TWrappingObject[] factoryObjects, Dictionary<TId, TObject> idToFactoryObject)
        {
            foreach (var factoryObject in factoryObjects)
            {
                if (idToFactoryObject.ContainsKey(factoryObject.Id))
                    throw new Exception("Error on InitializeDictionary: There is already a item with id" + factoryObject.Id);

                idToFactoryObject.Add(factoryObject.Id, factoryObject.GetObject());
            }
        }
    }
}