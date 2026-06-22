using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; 
    public float spawnInterval = 1.5f; 

    void Start()
    {
       
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // XÀ•W‚ğ -8 ‚©‚ç 8 ‚ÌŠÔ‚Åƒ‰ƒ“ƒ_ƒ€‚ÉŒˆ’è
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);

        // “G‚ğ¶¬
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}