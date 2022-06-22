using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public Text p1score, p2score, p3score, p4score;
    public GameObject player1, player2, player3, player4;

    private void Update() 
    { 
        StartCoroutine(updateScore());
    } 

    IEnumerator updateScore()
    {
        int p1 = player1.GetComponent<paddleController>().Poin;
        p1score.text = p1.ToString();

        int p2 = player2.GetComponent<paddleController>().Poin;
        p2score.text = p2.ToString();

        int p3 = player3.GetComponent<paddleController>().Poin;
        p3score.text = p3.ToString();

        int p4 = player4.GetComponent<paddleController>().Poin;
        p4score.text = p4.ToString();

        yield return null;
    }

}
