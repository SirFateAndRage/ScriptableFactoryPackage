using ScriptableFactoryPackage.FactoryObject;

namespace MonoFactorySample.FactoryObject
{
    public abstract class CharacterFactoryObject : MonoFactoryObject<string>
    {
        public abstract void DoSomething();
    }
}