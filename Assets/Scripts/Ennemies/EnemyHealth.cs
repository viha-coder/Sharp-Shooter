using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject robotExplosionVFX;
    [SerializeField] int startingHealth = 3;

    int currentHealth;

    GameManager gameManager;

    private void Awake() 
    {
      currentHealth = startingHealth;  
    }

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        gameManager.AdjustEnemiesLeft(1);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if(currentHealth <= 0)
        {    
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        gameManager.AdjustEnemiesLeft(-1);
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        Destroy(this.gameObject);        
    }
}
