using MonoFactorySample.FactoryObject;
using ScriptableFactoryPackage.Factory;
using UnityEngine;

namespace MonoFactorySample.Factory
{
    [CreateAssetMenu(fileName = "CharacterFactoryConfiguration", menuName = "CustomFactory/Configuration/MonoFactoryConfigurations/CharacterFactoryConfiguration", order = 1)]
    public class CharacterFactoryConfiguration : MonoFactoryConfiguration<CharacterFactoryObject,string>
    {

    }
}