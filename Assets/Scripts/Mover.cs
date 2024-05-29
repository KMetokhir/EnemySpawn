using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;     

    public void Move(Rigidbody rigidbody, Vector3 direction)
    {        
        rigidbody.velocity = direction*_speed;
    }   
}
