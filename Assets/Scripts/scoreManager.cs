using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    // method untuk menambah point pemain 
    [HideInInspector] public GameObject player;
    [HideInInspector] public int playerCount;
    public spawnManager spawn;
    public GameObject panelGameOver;
    [HideInInspector] public List<string> loser;
    private  string winner;
    private AudioSource sound;

    private void Start() {
        sound = GetComponent<AudioSource>();
    }

    // menambah pinalti poin ke pemain yang kebobolan
    public void AddPoint(string p) 
    { 
        player = GameObject.Find(p);
        player.GetComponent<paddleController>().PinaltiPoin += 1;
        player.GetComponent<paddleController>().Poin += 1;
    } 
 
    // menghitung jumlah pemain yang kalah
    public void AddCountLosingPlayer(int incre, string lose)
    {
        playerCount += incre;
        loser.Add(lose);
        if (playerCount == 3)
        {
            GameOver();
        }
    }

    // mencari siapa yang menang 
    public string WhoWin()
    {
        if(!(loser.Contains("player1")))
        {
            winner = "player 1";
        }else if (!(loser.Contains("player2")))
        {
            winner = "player 2";
        }else if (!(loser.Contains("player3")))
        {
            winner = "player 3";
        }else if (!(loser.Contains("player4")))
        {
            winner = "player 4";
        }
        return winner;
    }

    // method jika permainan selesai dan menampilkan nama pemenang dan panel game over
    public void GameOver() 
    { 
        panelGameOver.SetActive(true);
        spawn.maxPowerUpAmount = 0;
        spawn.removeAllBall();
        sound.Play();
        WhoWin();
    }

    public string Winner
    {
        get
        {
            return this.winner;
        }
    }
}
