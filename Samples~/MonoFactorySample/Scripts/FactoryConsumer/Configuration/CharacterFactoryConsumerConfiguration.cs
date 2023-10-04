using MonoFactorySample.Factory;
using MonoFactorySample.FactoryObject;
using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryConsumer;
using UnityEngine;

namespace MonoFactorySample.Consumer
{
    [CreateAssetMenu(fileName = "CharacterFactoryConsumerConfiguration", menuName = "CustomFactory/ConsumerConfiguration/MonoConsumerConfiguration/CharacterFactoryConsumerConfiguration", order = 1)]
    public class CharacterFactoryConsumerConfiguration : MonoConsumerConfiguration<CharacterFactoryObject, string>
    {
        [SerializeField] private GetPointToCameraConfiguration _poinToCameraConfiguration;
        private Transform _contentTransform;

        public void InitConfiguration(Transform contentTransform)
        {
            _contentTransform = contentTransform;
        }
        protected override IFactory<CharacterFactoryObject, string, CharacterFactoryObject> GetInitializeFactory(FactoryConfiguration<CharacterFactoryObject, string, CharacterFactoryObject> factoryConfiguration)
        {
            return new CharacterFactory(factoryConfiguration, _contentTransform, _poinToCameraConfiguration);
        }
    }
}