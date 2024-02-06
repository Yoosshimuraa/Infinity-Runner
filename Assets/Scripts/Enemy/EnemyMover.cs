using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _accelerationRate;

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        _speed += _accelerationRate * Time.deltaTime;
    }
}
