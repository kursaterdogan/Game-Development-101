using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class Launcher : MonoBehaviour
    {
        [SerializeField] private Bullet bulletPrefab;
        private IObjectPool<Bullet> _bulletPool;

        private void Awake()
        {
            SetUpBulletPool();
        }

        private void Update()
        {
            SpawnBullet();
        }

        private void SetUpBulletPool()
        {
            _bulletPool = new ObjectPool<Bullet>(
                CreatePooledItem,
                OnTakeFromPool,
                OnReturnedToPool,
                OnDestroyPoolObject,
                maxSize: 3
            );
        }

        private Bullet CreatePooledItem()
        {
            Bullet bullet = Instantiate(bulletPrefab);
            bullet.SetPool(_bulletPool);
            return bullet;
        }

        private void OnTakeFromPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = transform.position;
        }

        private void OnReturnedToPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(false);
        }

        private void OnDestroyPoolObject(Bullet bullet)
        {
            Destroy(bullet.gameObject);
        }

        private void SpawnBullet()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _bulletPool.Get();
            }
        }
    }
}