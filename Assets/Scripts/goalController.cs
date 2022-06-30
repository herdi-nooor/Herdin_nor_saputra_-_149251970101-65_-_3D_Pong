using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour
{ 
    public scoreManager score; 
    public spawnManager spawn;
    public GameObject player;
    public PhysicMaterial physicMaterial;
    [HideInInspector] public string p;
    private AudioSource sound;
 
    private void Start() 
    {
        sound = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider collision) 
    { 
        p = player.name;
        if (collision.GetComponent<Collider>().tag == "ball") 
        { 
            score.AddPoint(p);
            spawn.removeBall(collision.gameObject);
        }
        if(player.GetComponent<paddleController>().PinaltiPoin == 15)
        {
            score.AddCountLosingPlayer(1, p);
        }
    } 

    public void disableGoal()
    {
        sound.Play();
        GetComponent<Collider>().isTrigger = false;
        GetComponent<Renderer>().enabled = true;
        GetComponent<Collider>().material = physicMaterial;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<Collider>().enabled = false;
    }
}
