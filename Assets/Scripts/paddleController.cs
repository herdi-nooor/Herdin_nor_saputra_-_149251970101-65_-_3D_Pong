using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    private int speed = 20;
    public KeyCode rightKey;
    public KeyCode leftKey;
    private Rigidbody rig;
    private int pinaltiPoin;

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

        // check point if over
        if(pinaltiPoin == 15)
        {
            
        }

    }

    public int PinaltiPoin
    {
        set
        {
            this.pinaltiPoin = value;
        }
    }

    //funtion for get input from player
    private Vector3 GetInput() 
    { 
        if (Input.GetKey(rightKey))
        { 
            return new Vector3 (speed, 0, 0); 
        } 
        else if (Input.GetKey(leftKey))
        { 
            return new Vector3 (-speed, 0, 0); 
        } 
         
        return Vector3.zero; 
    } 

    // funtion for moving paddle
    private void MoveObject(Vector3 movement) 
    { 
        rig.velocity = movement; 
    }
}
