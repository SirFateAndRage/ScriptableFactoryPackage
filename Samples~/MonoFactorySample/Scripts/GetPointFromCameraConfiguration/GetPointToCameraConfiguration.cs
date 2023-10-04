using UnityEngine;

namespace MonoFactorySample.Factory
{
    [CreateAssetMenu(fileName = "GetPointToCameraConfiguration", menuName = "CustomFactory/ExampleConfiguration/GetPointToCameraConfiguration", order = 0)]
    public class GetPointToCameraConfiguration : ScriptableObject
    {
        public Vector3 GetRandomPoint()
        {
            int randomX = Random.Range(0, Screen.width);
            int randomY = Random.Range(0, Screen.height);

            Vector3 randomPointInViewport = new Vector3(randomX, randomY,-1);

            return randomPointInViewport;
        }
    }
}