using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentScreneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreneIndex + 1);
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
