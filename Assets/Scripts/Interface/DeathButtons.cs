using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathButtons : MonoBehaviour
{
    // If you died
    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
