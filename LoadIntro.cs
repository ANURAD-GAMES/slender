using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIntro : MonoBehaviour
{
    void Start()
    {
        Invoke("load", 24f);
    }
    private void load()
    {
        SceneManager.LoadScene("Prologue");
        Time.timeScale = 1f;
    }
}
