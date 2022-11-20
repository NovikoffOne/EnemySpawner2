using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    
    private Transform _targetPosition;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (_targetPosition == null)
        {
            _targetPosition = FindObjectOfType<Destroyer>().transform;
        }

        transform.position = Vector3.MoveTowards(transform.position, _targetPosition.position, _speed * Time.deltaTime);
    }
}
