using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorScript : MonoBehaviour {

    WheelCollider wheel;

	// Use this for initialization
	void Start () {
        print("TEST");
        GameObject wheelobj = GameObject.FindGameObjectWithTag("wheel");
        wheel = wheelobj.GetComponent<WheelCollider>();
        print(wheel.isGrounded);
	}
	
	// Update is called once per frame
	void Update () {
        print(wheel.isGrounded);
        if (Input.GetKey("up"))
        {
            wheel.brakeTorque = 0;
            wheel.motorTorque = 30 - Math.Abs(wheel.rpm);
            print(wheel.motorTorque);
        }
        else if(Input.GetKey("down"))
        {
            wheel.brakeTorque = 0;
            wheel.motorTorque = -(30 - Math.Abs(wheel.rpm));
            print(wheel.motorTorque);
        }
        else
        {
            wheel.motorTorque = 0;
            wheel.brakeTorque = 1;
        }
	}
}
