using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public ballController ball;
    public paddleController player;
    private int countPlayer;

    // method untuk menambah point pemain 
    public void AddPoint(int increment) 
    { 
        player.PinaltiPoin += increment;
    } 
 
    // method jika permainan selesao dan mengembalikan ke scene "Main menu"
    public void GameOver() 
    { 
        SceneManager.LoadScene("Main Menu");
    }
}
