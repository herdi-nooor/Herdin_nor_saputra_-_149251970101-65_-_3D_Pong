using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{    
    public KeyCode pauseKey;
    private void Update() {
        if (Input.GetKey(pauseKey))
        {
            Pause();
        }
    }

    public GameObject pauseBtn, pausePanel;
    // method untuk exit
    public void ExitGame() 
    { 
        Debug.Log("exit");
        Application.Quit();
    }
    
    // method untuk menjalankan scene "Game"
    public void PlayGame() 
    { 
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single); 
        Debug.Log("Created By Herdin nor saputra - 149251970101-65");
    } 
    
    // method untuk menjalankan scane "tutorial"
    public void Tutorial() 
    { 
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

     // method untuk kembali ke main menu
    public void Back() 
    { 
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single); 
    } 

    // replay game
    public void Replay()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    // pause
    public void Pause()
    {
        Time.timeScale = 0f;
        pauseBtn.SetActive(false);
        pausePanel.SetActive(true);
    }
    
    // resume 
    public void Resume()
    {
        Time.timeScale = 1.0f;
        pauseBtn.SetActive(true);
        pausePanel.SetActive(false);
    }
}
