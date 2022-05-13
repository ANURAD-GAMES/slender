using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel1 : MonoBehaviour
{
    void Start()
    {
        Invoke("load", 25f);
    }
    private void load()
    {
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }
}
