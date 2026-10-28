using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject infoPanel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        infoPanel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        // the pause menu functionality worked but buttons weren't able to be pressed due to the mouse still being locked onto 1st person camera, so adding this to both the resume and pause updates fixes that
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        
    }

    public void ShowInfo()
    {
        pauseMenuUI.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void ShowPauseMenu()
    {
        infoPanel.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void LoadMenu()

    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }

 
    
}
