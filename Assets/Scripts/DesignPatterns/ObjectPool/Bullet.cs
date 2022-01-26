using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] Vector3 speed;
        private IObjectPool<Bullet> _bulletPool;

        private void Update()
        {
            Move();
            StartCoroutine(ReleaseCoroutine());
        }

        public void SetPool(IObjectPool<Bullet> pool)
        {
            _bulletPool = pool;
        }

        private void Move()
        {
            transform.position += speed * Time.deltaTime;
        }

        private IEnumerator ReleaseCoroutine()
        {
            yield return new WaitForSeconds(1f);
            _bulletPool.Release(this);
        }
    }
}