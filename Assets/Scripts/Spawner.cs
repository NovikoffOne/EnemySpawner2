using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private int _countEnemy = 100;

    private float _waitSeconds = 2f;
    private WaitForSeconds _waitForSeconds;
    private Transform[] _spawnPosition;
    private Transform _curruntSpawn;
    private int _iteration = 0;

    private void Start()
    {
        _spawnPosition = GetComponentsInChildren<Transform>();

        _waitForSeconds = new WaitForSeconds(_waitSeconds);

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (_iteration < _countEnemy)
        {
            _curruntSpawn = _spawnPosition[Random.Range(0, _spawnPosition.Length)];

            var newEnemy = Instantiate(_enemy, _curruntSpawn.position, transform.rotation);

            _iteration++;

            yield return _waitForSeconds;
        }
    }
}
