using UnityEngine;
using System.Collections;

public class SpawnGate : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTime = 5f;
    [SerializeField] Transform spawnPoint;

    PlayerHealth player;
    private void Start() 
    {
        player = FindAnyObjectByType<PlayerHealth>();
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (player)
        {
            Instantiate(enemyPrefab, spawnPoint.position, transform.rotation);  
            yield return new WaitForSeconds(spawnTime);           
        }
    }
}
