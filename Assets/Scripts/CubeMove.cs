using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_rb.position.x <= _distance)
        {
            _rb.MovePosition(_rb.position + Vector3.right * Time.fixedDeltaTime * _speed);
        }
    }
}
