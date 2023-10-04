using UnityEngine;

namespace MonoFactorySample.FactoryObject
{
    public class FemaleCharacter : CharacterFactoryObject
    {
        public override void DoSomething()
        {
            //"It's only for ShowCase purposes,you must create your own logic
            Debug.Log("Hello there! I hope this sample has helped you.");
        }
    }
}