using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{
    public KeyCode rightKey, leftKey;
    public int pemain;
    [HideInInspector] public int speed;
    [HideInInspector] public Rigidbody rig;
    private int pinaltiPoin = 0, poin;
    // [HideInInspector] public GameObject scoreManager;
    [HideInInspector] public GameObject goal;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        goal = GameObject.Find("goalP" + pemain);
        speed = 6;
    }

    // Update is called once per frame
    private void Update()
    {
        // check point if over
        if(pinaltiPoin == 15)
        {
            // disable player if lose
            goal.GetComponent<goalController>().disableGoal();
            speed =  0;
            pinaltiPoin = 0;
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

    // getter setter
    public int Poin 
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
    }
}