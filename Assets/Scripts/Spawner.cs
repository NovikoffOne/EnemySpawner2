using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private float _waitSeconds = 2f;
    private float _nextSpawn;
    private Transform[] _spawnPosition;
    private Transform _curruntSpawn;

    private void Start()
    {
        _spawnPosition = GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        if (Time.time >= _nextSpawn)
        {
            _nextSpawn = Time.time + _waitSeconds;

            _curruntSpawn = _spawnPosition[Random.Range(0, _spawnPosition.Length)];

            GameObject newEnemy = Instantiate(_enemy, _curruntSpawn.position, transform.rotation);
        }
    }
}
