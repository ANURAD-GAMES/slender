using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_menu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject managementUI;
    public GameObject QuitUI;
    public GameObject TV;
    public GameObject Music;
    public GameObject Subtitles;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Subtitles.SetActive(false);
            TV.SetActive(false);
            Cursor.visible = true;
            GetComponent<AudioSource>().Pause();
            Music.SetActive(true);
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }
    //продолжить игру_________
    public void Resume()
    {
        Subtitles.SetActive(true);
        pauseMenuUI.SetActive(false);
        managementUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        GetComponent<AudioSource>().Play();
        TV.SetActive(true);
        Music.SetActive(false);
    }
    void Pause()
    {
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //________________________



   //Выход в главное меню_______
    public void QuitUIMenu()
    {
        QuitUI.SetActive(true);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitPanel()
    {
        QuitUI.SetActive(false);
    }
    //__________________________







    //Управление__________________
    public void management()
    {
        managementUI.SetActive(true);
    }
    public void managementQuit()
    {
        managementUI.SetActive(false);
    }
    //____________________________
}

