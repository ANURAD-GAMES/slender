using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Prologue");
        Time.timeScale = 1f;

    }
    public void LoadLevels()
    {
        SceneManager.LoadScene("LoadGame");
        Time.timeScale = 1f;

    }
    public void NewIntro()
    {
        SceneManager.LoadScene("NewGameIntro");
        Time.timeScale = 1f;

    }
}
