using ScriptableFactoryPackage.Factory;
using ScriptableFactoryPackage.FactoryObject;
using System;
using UnityEngine;

namespace ScriptableFactoryPackage.FactoryConsumer
{
    public abstract class FactoryConsumer<TFactory, TObject, TId, TWrappingObject> : MonoBehaviour, IConsumer<TId>
    where TFactory : IFactory<TObject, TId, TWrappingObject>
    where TWrappingObject : IIdentifator<TId>
    {
        [SerializeField] private ConsumerConfiguration<TObject, TId, TWrappingObject> _consumerConfiguration;

        private TFactory _factory;

        protected TFactory Factory { get => _factory; }

        private void Awake() => _factory = GetFactory(_consumerConfiguration);

        protected abstract TFactory GetFactory(ConsumerConfiguration<TObject, TId, TWrappingObject> consumerConfiguration);

        public abstract void ConsumeFactoryObject(TId id);
    }
}