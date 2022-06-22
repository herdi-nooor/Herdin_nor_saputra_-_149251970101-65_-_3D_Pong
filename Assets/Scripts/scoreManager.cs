using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    // method untuk menambah point pemain 
    private GameObject player;
    private int playerCount;
    private spawnManager spawn;
    public GameObject panelGameOver;

    // menambah pinalti poin ke pemain yang kebobolan
    public void AddPoint(string p) 
    { 
        player = GameObject.Find(p);
        player.GetComponent<paddleController>().PinaltiPoin += 1;
        player.GetComponent<paddleController>().Poin += 1;
    } 
 
    // menghitung jumlah pemain yang kalah
    public void AddCountLosingPlayer(int intcre)
    {
        playerCount += intcre;
        Debug.Log(playerCount);
        if (playerCount == 3)
        {
            GameOver();
        }
    }

    // method jika permainan selesai dan mengembalikan ke scene "Main menu"
    public void GameOver() 
    { 
        panelGameOver.SetActive(true);
    }

}
