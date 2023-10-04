using UnityEngine;

namespace MonoFactorySample.FactoryObject
{
    public class MaleCharacter : CharacterFactoryObject
    {
        public override void DoSomething()
        {
            //"It's only for ShowCase purposes,you must create your own logic
            Debug.Log("I hope this sample has helped you.");
        }
    }
}