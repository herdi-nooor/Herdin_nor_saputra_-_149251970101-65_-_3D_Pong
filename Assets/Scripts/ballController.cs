using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Vector3 forceDirection;
    public int baseSpeed;
    public PhysicMaterial physicMaterial;
    [HideInInspector] public int speed, powerInterval;
    [HideInInspector] public Rigidbody rig;
    private float timerSpeed;
    private bool powerSpeedUP;
    private AudioSource sound;

    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
        // mengatur arah pergerakan awal bola
        rig.AddForce(forceDirection.x, forceDirection.y, forceDirection.z, ForceMode.Impulse);
        powerSpeedUP = false;
        speed = baseSpeed;
        powerInterval = 1;
    }

    private void Update() {
        rig = GetComponent<Rigidbody>();
        // menjaga speed bola menjadi constan/tetap
        rig.velocity = rig.velocity.normalized * speed;
        // check is power up speed active
        if (powerSpeedUP == true)
        {
            timerSpeed += Time.deltaTime;
    
            if (timerSpeed > powerInterval) 
            { 
                resetSpeed();
                powerSpeedUP = false;
                timerSpeed -= powerInterval; 
            }
        }
    }

    // mencegah bola memantul tidak beraturan apabila sudah menyentuh lantai 
    // dengan cara mengatifkan freezePositionY di constrain lalu mengset physicmaterial nya
    // kondisi awal bola memiliki 
    // drag = 0.001 (agar bisa jatuh labih cepat dan seperti bola besi)
    // physicmaterialnya = none (agar jika belum menyetuh lantai, tidak akan memantul tinggi)
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "ground")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;
            rig.drag = 0;
            rig.GetComponent<Collider>().material = physicMaterial;
        }else if (other.gameObject.tag == "ball")
        {
            sound.Play();
        }else
        {
            return;
        }
    }

    public void resetSpeed()
    {
        speed = baseSpeed;
    }
    public void ActivatePUSpeed()
    {
        if (powerSpeedUP == false)
        {
            speed += 5;
            powerSpeedUP = true;
        }
    }
}
