using MonoFactorySample.FactoryObject;
using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryConsumer;
using UnityEngine;

namespace MonoFactorySample.Consumer
{
    public class CharacterFactoryConsumer : MonoFactoryConsumer<CharacterFactoryObject, string>
    {
        [SerializeField] private Transform _content;
        [SerializeField] private string _objectKey;

        public override void ConsumeFactoryObject(string id)
        {
            CharacterFactoryObject factoryObject = Factory.GetObject(id);
            factoryObject.DoSomething();
        }

        protected override MonoFactory<CharacterFactoryObject, string> GetFactory(ConsumerConfiguration<CharacterFactoryObject, string, CharacterFactoryObject> consumerConfiguration)
        {
            CharacterFactoryConsumerConfiguration MyConfiguration = consumerConfiguration as CharacterFactoryConsumerConfiguration;

            MyConfiguration.InitConfiguration(_content);

            return (MonoFactory<CharacterFactoryObject, string>)MyConfiguration.GetFactory();
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
                ConsumeFactoryObject(_objectKey);
        }
    }
}