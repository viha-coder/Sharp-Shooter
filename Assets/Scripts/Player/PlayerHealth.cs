using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.UI;
using StarterAssets;

public class PlayerHealth : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] int startingHealth = 5;
    [SerializeField] CinemachineVirtualCamera deathVirtualCamera;
    [SerializeField] Transform weaponCamera;
    [SerializeField] Image[] shieldBars;
    [SerializeField] GameObject gameOverContainer;

    int currentHealth;
    int gameOverVirtualCameraPriority = 20;

    private void Awake() 
    {
      currentHealth = startingHealth;
      AdjustShieldUI();  
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        AdjustShieldUI();

        if(currentHealth <= 0)
        {
            PlayerGameOver();
        }
    }

    private void PlayerGameOver()
    {
        weaponCamera.parent = null;
        deathVirtualCamera.Priority = gameOverVirtualCameraPriority;
        gameOverContainer.SetActive(true);
        StarterAssetsInputs starterAssetsInputs = FindAnyObjectByType<StarterAssetsInputs>();
        starterAssetsInputs.SetCursorState(false);

        Destroy(this.gameObject);
    }

    private void AdjustShieldUI()
    {
        for(int i = 0; i < shieldBars.Length; i++)
        {
            if(i < currentHealth)
            {
                shieldBars[i].gameObject.SetActive(true);
            }
            else
            {
                shieldBars[i].gameObject.SetActive(false);
            }
        }
    }
}
