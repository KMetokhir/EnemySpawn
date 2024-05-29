using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void MoveTo(Vector3 direction)
    {
        _mover.MoveByVelocityChange(_rigidbody, direction);
    }
}
