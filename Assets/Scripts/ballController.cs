using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Vector3 forceDirection;
    public int speed;
    [HideInInspector] public Rigidbody rig;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.AddForce(forceDirection.x, forceDirection.y, forceDirection.z, ForceMode.Impulse);
    }

    private void Update() {
        rig = GetComponent<Rigidbody>();
        // menjaga speed bola menjadi constan/tetap
        rig.velocity = rig.velocity.normalized * speed;
    }

    // mencegah bola memantul apabila sudah menyentuh lantai 
    // dengan cara mengatifkan freezePositionY di constrain
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "ground")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
}
