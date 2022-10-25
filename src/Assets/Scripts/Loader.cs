using UnityEngine;

namespace Shaders
{
    public static class Loader
    {
        public static T LoadMonoBehaviour<T>(string path) where T : MonoBehaviour
        {
            return Resources.Load<T>(path);
        }
    }
}
