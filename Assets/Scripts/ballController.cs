using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{

    public Vector3 speed;
    [HideInInspector] public Rigidbody rig;
    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce(speed.x, speed.y, speed.z, ForceMode.Impulse);
    }


}
