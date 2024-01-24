using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0; // Reset timer to 0 instead of 1 for accuracy
        }
    }

    void SpawnEnemy()
    {
        // Spawn the enemy within a 3-unit radius of the spawner
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * 3;
        spawnPosition.y = 0; // Adjust y coordinate as needed (set to 0 here for example)

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
