using System.Collections;
using UnityEngine;

namespace CubeSpawn
{
    public class GameController : MonoBehaviour
    {
        [Header("Cubes")]
        [SerializeField] private Transform cubeSpawnPoint;
        [SerializeField] private CustomCube cubePrefab;

        private int _spawnDelay = 5;
        private int _cubeSpeed = 2;
        private int _cubeDistance = 10;


        private void Start()
        {
            UiController.OnDelayValueChanged += OnDelayValueChanged;
            UiController.OnSpeedValueChanged += OnSpeedValueChanged;
            UiController.OnDistanceValueChanged += OnDistanceValueChanged;

            StartCoroutine(Spawn());
        }

        private void OnDestroy()
        {
            UiController.OnDelayValueChanged -= OnDelayValueChanged;
            UiController.OnSpeedValueChanged -= OnSpeedValueChanged;
            UiController.OnDistanceValueChanged -= OnDistanceValueChanged;
        }


        private IEnumerator Spawn()
        {
            while (true)
            {
                yield return new WaitForSeconds(_spawnDelay);

                var cube = Instantiate(cubePrefab, cubeSpawnPoint);
                cube.Init(_cubeSpeed, _cubeDistance);
            }
        }

        private void OnDelayValueChanged(int value)
        {
            _spawnDelay = value;
        }

        private void OnSpeedValueChanged(int value)
        {
            _cubeSpeed = value;
        }

        private void OnDistanceValueChanged(int value)
        {
            _cubeDistance = value;
        }
    }
}
