using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBoatController : MonoBehaviour
{

    public float BoatSpeed;
    public int BoatCrashes;
    public GameObject BoatMotor;
    public Rigidbody BoatMotorBody;

    // Start is called before the first frame update
    void Start()
    {

        //Gets the rigidbody from the boat motor.
        BoatMotorBody = BoatMotor.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        //Gets the directional button presses.
        var key_up = Input.GetKey(KeyCode.W);
        var key_down = Input.GetKey(KeyCode.S);
        var key_left = Input.GetKey(KeyCode.A);
        var key_right = Input.GetKey(KeyCode.D);

        //Applies force to the boat motor.
        BoatMotorBody.AddRelativeForce(Vector3.up * (Convert.ToInt32(key_up) - Convert.ToInt32(key_down)) * BoatSpeed);
        BoatMotor.transform.Rotate(new Vector3(0, 0, (Convert.ToInt32(key_left) - Convert.ToInt32(key_right))));

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Boat")
        {
            BoatCrashes += 1;
        }
    }
}
