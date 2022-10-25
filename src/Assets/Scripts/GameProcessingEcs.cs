using Leopotam.Ecs;
using UnityEngine;

namespace Shaders
{
    public sealed class GameProcessingEcs : MonoBehaviour
    {
        EcsWorld _world;
        EcsSystems _systems;

        private void Awake()
        {
            _world = new EcsWorld();
            _systems = new EcsSystems(_world);

            InitSystems();

            void InitSystems()
            {
                _systems
                    .Add(new Instantiater())
                    .Init();
            }
        }

        private void Update()
        {
            _systems?.Run();
        }

        private void OnDestroy()
        {
            _world.Destroy();
            _world = null;

            _systems.Destroy();
            _systems = null;
        }
    }
}
