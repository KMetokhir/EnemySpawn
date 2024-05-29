using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;

    private void Start()
    {
        _enemySpawner.StartSpawn();
    }
}
