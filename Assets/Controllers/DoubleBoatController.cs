using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoubleBoatController : MonoBehaviour
{

    public float BoatSpeed;
    public int BoatCrashes;
    public GameObject BoatMotor1;
    public Rigidbody BoatMotorBody1;
    public GameObject BoatMotor2;
    public Rigidbody BoatMotorBody2;
    public TextMeshPro TextTime;
    public TextMeshPro TextCrashes;

    // Start is called before the first frame update
    void Start()
    {

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
        BoatMotorBody1.AddRelativeForce(Vector3.up * (Convert.ToInt32(key_up) - Convert.ToInt32(key_down)) * BoatSpeed);
        BoatMotor1.transform.Rotate(new Vector3(0, 0, (Convert.ToInt32(key_left) - Convert.ToInt32(key_right))));

        //Gets the directional button presses.
        key_up = Input.GetKey(KeyCode.UpArrow);
        key_down = Input.GetKey(KeyCode.DownArrow);
        key_left = Input.GetKey(KeyCode.LeftArrow);
        key_right = Input.GetKey(KeyCode.RightArrow);

        //Applies force to the boat motor.
        BoatMotorBody2.AddRelativeForce(Vector3.up * (Convert.ToInt32(key_up) - Convert.ToInt32(key_down)) * BoatSpeed);
        BoatMotor2.transform.Rotate(new Vector3(0, 0, -(Convert.ToInt32(key_left) - Convert.ToInt32(key_right))));

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Boat")
        {
            BoatCrashes += 1;
            TextCrashes.text = "Crashes: " + BoatCrashes.ToString();
        }
    }
}
