using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public Text p1score, p2score, p3score, p4score;
    private GameObject player;

    private void Update() 
    { 
        StartCoroutine(updateScore());
    } 

    IEnumerator updateScore()
    {
        player = GameObject.Find("player1");
        int p = player.GetComponent<paddleController>().PinaltiPoin;
        p1score.text = p.ToString();
        // p2score.text = (player[1].GetComponent<paddleController>.PinaltiPoin).ToString();
        // p3score.text = (player3.GetComponent<paddleController>.PinaltiPoin).ToString();
        // p4score.text = (player4.GetComponent<paddleController>.PinaltiPoin).ToString();
        yield return null;
    }

}
