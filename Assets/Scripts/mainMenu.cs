using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{    
    // method untuk exit
    public void ExitGame() 
    { 
        Application.Quit();
    }
    
    // method untuk menjalankan scene "Game"
    public void PlayGame() 
    { 
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
        SceneManager.LoadScene("GamePlay", LoadSceneMode.Single);
    }
}
