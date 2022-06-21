using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController2 : MonoBehaviour
{
    private int speed = 20;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        // moveing object  width input
        MoveObject(GetInput());

    }

    //funtion for get input from player
    private Vector3 GetInput() 
    { 
        if (Input.GetKey(upKey))
        { 
            return new Vector3 (0, 0, speed); 
        } 
        else if (Input.GetKey(downKey))
        { 
            return new Vector3 (0, 0, -speed); 
        } 
         
        return Vector3.zero; 
    } 

    // funtion for moving paddle
    private void MoveObject(Vector3 movement) 
    { 
        rig.velocity = movement; 
    }
}
