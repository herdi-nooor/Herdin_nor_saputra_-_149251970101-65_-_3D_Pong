using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour
{ 
    public scoreManager score; 
    public spawnManager spawn;
    public GameObject player;
 
    private void OnTriggerEnter(Collider collision) 
    { 
        string p = player.name;
        if (collision.GetComponent<Collider>().tag == "ball") 
        { 
            score.AddPoint(p);
            spawn.removeBall(collision.gameObject);
        }
        if(player.GetComponent<paddleController>().PinaltiPoin == 3)
        {
            score.AddCountLosingPlayer(1);
        }
    } 

    public void disableGoal()
    {
        GetComponent<Collider>().isTrigger = false;
        GetComponent<Renderer>().enabled = true;
    }
}
