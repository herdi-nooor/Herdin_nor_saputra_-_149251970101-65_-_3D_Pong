using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{    
    public KeyCode pauseKey;
    private AudioSource sound;

    private void Start() {
        sound = GetComponent<AudioSource>();
    }
    
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
        sound.Play();
        Debug.Log("exit");
        Application.Quit();
    }
    
    // method untuk menjalankan scene "Game"
    public void PlayGame() 
    { 
        sound.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single); 
        Debug.Log("Created By Herdin nor saputra - 149251970101-65");
    } 
    
    // method untuk menjalankan scane "tutorial"
    public void Tutorial() 
    { 
        sound.Play();
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

     // method untuk kembali ke main menu
    public void Back() 
    {
        sound.Play(); 
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Single); 
    } 

    // replay game
    public void Replay()
    {
        sound.Play();
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }

    // pause
    public void Pause()
    {
        sound.Play();
        Time.timeScale = 0f;
        pauseBtn.SetActive(false);
        pausePanel.SetActive(true);
    }
    
    // resume 
    public void Resume()
    {
        sound.Play();
        Time.timeScale = 1.0f;
        pauseBtn.SetActive(true);
        pausePanel.SetActive(false);
    }
}
