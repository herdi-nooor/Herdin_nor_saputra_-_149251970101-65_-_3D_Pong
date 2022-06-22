using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    public KeyCode rightKey;
    public KeyCode leftKey;
    public int pemain;
    private int speed = 20;
    private Rigidbody rig;
    private int pinaltiPoin = 0, poin;
    private GameObject scoreManager;
    private GameObject goal;


    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        goal = GameObject.Find("goalP" + pemain);
    }

    // Update is called once per frame
    private void Update()
    {
        // check point if over
        if(pinaltiPoin == 3)
        {
            // disable player if lose
            goal.GetComponent<goalController>().disableGoal();
            speed =  0;
            pinaltiPoin = 0;
            scoreManager = GameObject.Find("scoreManager");
        }
        else
        {
            // moveing object  width input
            MoveObject(GetInput());
        }

    }



    //funtion for get input from player
    private Vector3 GetInput() 
    { 
        if (pemain == 1 || pemain == 4)
        {
            if (Input.GetKey(rightKey))
            { 
                return new Vector3 (speed, 0, 0); 
            } 
            else if (Input.GetKey(leftKey))
            { 
                return new Vector3 (-speed, 0, 0); 
            } 
        }
        else if(pemain == 2 || pemain == 3)
        {
            if (Input.GetKey(rightKey))
            { 
                return new Vector3 (0, 0, speed); 
            } 
            else if (Input.GetKey(leftKey))
            { 
                return new Vector3 (0, 0, -speed); 
            }  
        }
        return Vector3.zero; 
    } 

    // funtion for moving paddle
    private void MoveObject(Vector3 movement) 
    { 
        rig.velocity = movement; 
    }
    public int PinaltiPoin
    {
        get
        {
            return this.pinaltiPoin;
        }
        set
        {
            this.pinaltiPoin = value;
        }
    }public int Poin
    {
        get
        {
            return this.poin;
        }
        set
        {
            this.poin = value;
        }
    }
}
