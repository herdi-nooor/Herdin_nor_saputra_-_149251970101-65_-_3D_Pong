using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpController : MonoBehaviour
{
    public spawnManager manager;
    
    private void OnTriggerEnter(Collider collision) 
    { 
        if (collision.GetComponent<Collider>().tag == "ball") 
        { 
            collision.GetComponent<ballController>().ActivatePUSpeed(); 
            manager.RemovePower(gameObject); 
        }     
    } 
}
