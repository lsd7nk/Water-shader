using Leopotam.Ecs;
using UnityEngine;

namespace Shaders
{
    public sealed class Instantiater : IEcsInitSystem
    {
        public void Init()
        {
            var waterSphere = Loader.LoadMonoBehaviour<ShaderObject>("WaterSphere");

            Instantiate(waterSphere);
        }

        public static void Instantiate(Object obj)
        {
           Object.Instantiate(obj, Vector3.up, Quaternion.identity);
        }
    }
}
