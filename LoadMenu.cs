using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    void Start()
    {
     
        Invoke("load", 11f);
    }
    private void load()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
