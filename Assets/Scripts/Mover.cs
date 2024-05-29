using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _acceleration;
    [SerializeField] private float _maxSpeed;

    private bool _isMoving = false;
    private Vector3 _direction;
    private Rigidbody _movableRigidbody;

    private void FixedUpdate()
    {
        if (_isMoving)
        {
            Move();
        }
    }

    public void Move(Rigidbody rigidbody, Vector3 direction)
    {
        _direction = direction;
        _movableRigidbody = rigidbody;
        _isMoving = true;
    }

    private void Move()
    {
        if (_movableRigidbody.velocity.magnitude <= _maxSpeed)
        {
            _movableRigidbody.AddForce(_direction * _acceleration);
        }
    }
}
