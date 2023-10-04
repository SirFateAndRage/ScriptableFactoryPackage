using ScriptableFactoryPackage.FactoryObject;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableFactoryPackage.Factory
{
    [CreateAssetMenu(fileName = "Default", menuName = "CustomFactory/Configuration/MonoFactoryConfigurations/DefaultConfiguration", order = -1)]
    public class MonoFactoryConfiguration<TObject, TId> : FactoryConfiguration<TObject, TId, TObject>
    where TObject : IIdentifator<TId>
    {
        protected override void SetInitialConfiguration(TObject[] factoryObjects, Dictionary<TId, TObject> idToFactoryObject)
        {
            foreach (TObject factoryObject in factoryObjects)
            {
                if (idToFactoryObject.ContainsKey(factoryObject.Id))
                    throw new Exception("Error on InitializeDictionary: There is already a item with id" + factoryObject.Id);

                idToFactoryObject.Add(factoryObject.Id, factoryObject);
            }
        }
    }
}