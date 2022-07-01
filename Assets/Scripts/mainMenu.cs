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
            if (pauseBtn.activeSelf)
            {
                Pause();
            }else{
                return;
            }
        }
    }

    IEnumerator waitForPlay(string scene)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
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
        StartCoroutine(waitForPlay("GamePlay")); 
        Debug.Log("Created By Herdin nor saputra - 149251970101-65");
    } 
    
    // method untuk menjalankan scane "tutorial"
    public void Tutorial() 
    { 
        sound.Play();
        StartCoroutine(waitForPlay("Tutorial"));
    }

     // method untuk kembali ke main menu
    public void Back() 
    {
        sound.Play();
        Time.timeScale = 1.0f; 
        StartCoroutine(waitForPlay("Main Menu"));
    } 

    // replay game
    public void Replay()
    {
        sound.Play();
        Time.timeScale = 1.0f;
        StartCoroutine(waitForPlay("GamePlay"));
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
