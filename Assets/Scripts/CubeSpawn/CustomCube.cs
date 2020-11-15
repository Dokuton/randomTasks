using System.Collections;
using UnityEngine;

namespace CubeSpawn
{
    public class CustomCube : MonoBehaviour
    {
        private float _speed;
        private float _distance;


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
                StartCoroutine(Move());
        }

        public void Init(float speed, float distance)
        {
            _speed = speed <= 0 || speed > 10 ? 1 : speed;
            _distance = distance < 0 || distance > 200 ? 10 : distance;
        }


        private IEnumerator Move()
        {
            while (_distance > 0)
            {
                var oldZ = transform.position.z;

                transform.Translate(transform.forward * _speed * Time.deltaTime);

                _distance -= Mathf.Abs(transform.position.z - oldZ);

                yield return null;
            }

            Destroy();
        }

        private void Destroy()
        {
            Destroy(gameObject);
        }
    }
}