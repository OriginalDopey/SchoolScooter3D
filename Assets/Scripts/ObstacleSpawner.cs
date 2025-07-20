using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public Transform player;
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float spawnY = 0f;
    public float spawnInterval = 2f;
    public float spawnDistance = 20f;

    private float lastSpawnZ = 0f;

    void Start()
    {
        if (player != null)
            lastSpawnZ = player.position.z - spawnInterval;
    }

    void Update()
    {
        if (obstaclePrefabs.Length == 0 || player == null)
        {
            Debug.LogWarning("ObstacleSpawner: No prefabs or player not assigned.");
            return;
        }
        // Spawn obstacles for every interval crossed since last spawn
        while (player.position.z - lastSpawnZ >= spawnInterval)
        {
            int index = Random.Range(0, obstaclePrefabs.Length);
            float x = Random.Range(minX, maxX);
            Vector3 spawnPos = new Vector3(x, spawnY, lastSpawnZ + spawnInterval + spawnDistance);
            Instantiate(obstaclePrefabs[index], spawnPos, Quaternion.identity);
            Debug.Log($"Spawned obstacle {index} at {spawnPos}");
            lastSpawnZ += spawnInterval;
        }
    }
}
