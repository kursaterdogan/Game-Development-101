using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class Bullet : MonoBehaviour
    {
        private IObjectPool<Bullet> _bulletPool;

        [SerializeField] Vector3 speed;

        private void OnEnable()
        {
            StartCoroutine(ReleaseCoroutine());
        }

        private void Update()
        {
            Move();
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