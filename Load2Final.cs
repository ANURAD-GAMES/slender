using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load2Final : MonoBehaviour
{
    void Start()
    {
        Invoke("load", 22f);
    }
    private void load()
    {
        SceneManager.LoadScene("Level2(Final)");
        Time.timeScale = 1f;
    }
}
