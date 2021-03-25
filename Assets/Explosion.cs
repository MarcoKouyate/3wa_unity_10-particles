using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class Explosion : MonoBehaviour
    {
        [SerializeField] private GameObject _explosionParticle;
        [SerializeField] private LayerMask _clickableLayers;

        private void Awake()
        {
            
        }

        private void Update()
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Explode();
            }
        }

        private void Explode()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, _clickableLayers))
            {
                Instantiate(_explosionParticle, hit.point, Quaternion.identity);
            }
        }
    }
}
