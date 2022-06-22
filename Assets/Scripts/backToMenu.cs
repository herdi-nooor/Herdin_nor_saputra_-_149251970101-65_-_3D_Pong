using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
     // method untuk kembali ke main menu
    public void Back() 
    { 
        SceneManager.LoadScene("Main Menu"); 
    } 
}
