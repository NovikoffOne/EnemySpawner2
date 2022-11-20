using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _countEnemy = 100;

    private Transform[] _spawnPosition;
    private Transform _curruntSpawn;
    private int _iteration = 0;

    private void Start()
    {
        _spawnPosition = GetComponentsInChildren<Transform>();

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (_iteration < _countEnemy)
        {
            _curruntSpawn = _spawnPosition[Random.Range(0, _spawnPosition.Length)];

            GameObject newEnemy = Instantiate(_enemy, _curruntSpawn.position, transform.rotation);

            _iteration++;

            yield return new WaitForSeconds(2f);
        }
    }
}
