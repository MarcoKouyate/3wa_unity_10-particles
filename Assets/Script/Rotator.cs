
using UnityEngine;

namespace Particles {
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private Transform _child;

        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            float rotation = _speed * Time.deltaTime;
            _transform.Rotate(Vector3.forward, rotation);
            _child.Rotate(Vector3.forward, rotation);
        }

        private Transform _transform;
    }
}
