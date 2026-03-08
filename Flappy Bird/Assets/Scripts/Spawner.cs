using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;
    [SerializeField] float spawnTime = 3f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnPipes), 2f, spawnTime);
    }


    void SpawnPipes()
    {
        Vector3 newPos = new Vector3(transform.position.x, Random.Range(-2,3), transform.position.z);
        Instantiate(pipesPrefab, newPos, Quaternion.identity);
    }
}
