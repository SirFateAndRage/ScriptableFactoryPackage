using MonoFactorySample.FactoryObject;
using ScriptableFactoryPackage.Factory;
using UnityEngine;

namespace MonoFactorySample.Factory
{
    public class CharacterFactory : MonoFactory<CharacterFactoryObject, string>
    {
        private Transform _content;
        private GetPointToCameraConfiguration _getPointToCamera;
        public CharacterFactory(FactoryConfiguration<CharacterFactoryObject, string, CharacterFactoryObject> factoryConfiguration, Transform content, GetPointToCameraConfiguration getPointToCamera) : base(factoryConfiguration)
        {
            _content = content;
            _getPointToCamera = getPointToCamera;
        }

        protected override CharacterFactoryObject GetObject(string id, FactoryConfiguration<CharacterFactoryObject, string, CharacterFactoryObject> factoryConfiguration)
        {
            CharacterFactoryObject character = factoryConfiguration.GetFactoryObjectById(id);

            return Object.Instantiate(character,_getPointToCamera.GetRandomPoint(),_content.rotation,_content);
        }
    }
}