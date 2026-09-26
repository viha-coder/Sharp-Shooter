using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using StarterAssets;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text enemiesLeftText;
    [SerializeField] GameObject youWinContainer;

    int enemiesLeft = 0;

    const string ENEMIES_LEFT_TEXT = "Enemies Left: ";

    public void AdjustEnemiesLeft(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = ENEMIES_LEFT_TEXT + enemiesLeft.ToString();

        if (enemiesLeft <= 0)
        {
            PlayerWin();
        }
    }

    private void PlayerWin()
    {
        youWinContainer.SetActive(true);
        StarterAssetsInputs starterAssetsInputs = FindAnyObjectByType<StarterAssetsInputs>();
        starterAssetsInputs.SetCursorState(false);
    }

    public void RestartLevelButton()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void QuitGameButton()
    {
        Debug.LogWarning("You are quitting the game. If you are in the editor, this will not work.");
        Application.Quit();
    }
}
