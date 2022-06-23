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
    private scoreController scoreController;
    public GameObject panelGameOver;
    private List<string> loser;
    private string winner;

    // menambah pinalti poin ke pemain yang kebobolan
    public void AddPoint(string p) 
    { 
        player = GameObject.Find(p);
        player.GetComponent<paddleController>().PinaltiPoin += 1;
        player.GetComponent<paddleController>().Poin += 1;
    } 
 
    // menghitung jumlah pemain yang kalah
    public void AddCountLosingPlayer(string lose)
    {
        loser.Add(lose);
        playerCount += 1;
        if (playerCount == 3)
        {
            foreach (var item in this.loser)
            {
                Debug.Log(item);
            }
            GameOver();
        }
    }

    public string WhoWin()
    {
        Debug.Log(winner);
        if(!(loser.Contains("player1")))
        {
            return winner = "player 1";
        }else if (!(this.loser.Contains("player2")))
        {
            return winner = "player 2";
        }else if (!(loser.Contains("player3")))
        {
            return winner = "player 3";
        }else
        {
            return winner = "player 4";
        }
    }

    // method jika permainan selesai dan mengembalikan ke scene "Main menu"
    public void GameOver() 
    { 
        Debug.Log("winner " + WhoWin());
        scoreController.winner.text = WhoWin();
        panelGameOver.SetActive(true);
    }

}
