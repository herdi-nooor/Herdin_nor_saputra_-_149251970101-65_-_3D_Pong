using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour
{
    public Text p1score, p2score, p3score, p4score;
    public  Text wining;
    public GameObject score;
    public GameObject player1, player2, player3, player4;
    [HideInInspector] public string win;

    private void Update() 
    { 
        StartCoroutine(updateScore());
    } 

    private IEnumerator updateScore()
    {
        int p1 = player1.GetComponent<paddleController>().Poin;
        p1score.text = "P1\n" + p1.ToString();

        int p2 = player2.GetComponent<paddleController>().Poin;
        p2score.text = "P2\n" + p2.ToString();

        int p3 = player4.GetComponent<paddleController>().Poin;
        p3score.text = "P3\n" + p3.ToString();

        int p4 = player3.GetComponent<paddleController>().Poin;
        p4score.text = "P4\n" + p4.ToString();


        if (!(score.GetComponent<scoreManager>().panelGameOver.activeInHierarchy))
        {
            Debug.Log("scor handelling");
        }else{
            ending();
        }

        yield return null;
    }
    public void ending()
    {
        win = score.GetComponent<scoreManager>().Winner;
        wining.text = win ;
    }

}
