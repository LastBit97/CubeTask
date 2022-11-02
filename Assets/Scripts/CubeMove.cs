using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;
    [SerializeField] private float _distance;

    public float Speed
    {
        get => _speed; set
        {
            if (value >= 0) _speed = value;
        }
    }
    public float Distance
    {
        get => _distance; set
        {
            if (value >= 0) _distance = value;
        }
    }

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
        else Destroy(gameObject);
    }
}
