using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    
    private Transform _targetPosition;

    private void Update()
    {
        MoveEnemy();
    }

    public void KillEnemy()
    {
        Destroy(this.gameObject);
    }

    private void MoveEnemy()
    {
        if (_targetPosition == null)
        {
            _targetPosition = GameObject.Find("Point").transform;
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.position, _speed * Time.deltaTime);
    }
}
