using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;     

    public void MoveByVelocityChange(Rigidbody rigidbody, Vector3 direction)
    {        
        rigidbody.velocity = direction.normalized*_speed;
    }   
}
