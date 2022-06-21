using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{

    public Vector3 speed;
    private Rigidbody rig;
    private string Paddle;

    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
    }

    public string paddle
    {
        get
        {
            return this.Paddle;
        }
    }

    // mengecek gawang mana yang terakhir di tabrak oleh bola
    private void OnCollisionEnter2D (Collision2D collisionInfo) 
    {
        string lastCollision = collisionInfo.collider.tag;
        string name = collisionInfo.collider.name;
        if ( lastCollision == "goal")
        {
            Paddle = name;
        }
    }
}
