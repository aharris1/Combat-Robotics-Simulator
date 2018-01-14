using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveDriveController : MonoBehaviour {
    public WheelCollider frontLeft;
    public WheelCollider frontRight;
    public WheelCollider backLeft;
    public WheelCollider backRight;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            setAllMotorTorques(10);    
        }
        else if (Input.GetKey("down"))
        {
            setAllMotorTorques(10);
        }
        else
        {
            setAllMotorTorques(0);
        }
        if (Input.GetKey("left"))
        {
            incrementAllSteerAngles(-2);
        }
        else if (Input.GetKey("right"))
        {
            incrementAllSteerAngles(2);
        }

	}

    void incrementAllSteerAngles(float degrees)
    {
        frontLeft.steerAngle = (frontLeft.steerAngle + degrees) % 360;
        frontRight.steerAngle = (frontRight.steerAngle + degrees) % 360;
        backLeft.steerAngle = (backLeft.steerAngle + degrees) % 360;
        backRight.steerAngle = (backRight.steerAngle + degrees) % 360;
    }

    void setAllSteerAngles(float degrees)
    {
        frontLeft.steerAngle = degrees;
        frontRight.steerAngle = degrees;
        backLeft.steerAngle = degrees;
        backRight.steerAngle = degrees;
    }

    void setAllBrakeTorque(float torque)
    {
        frontLeft.brakeTorque = torque;
        frontRight.brakeTorque = torque;
        backLeft.brakeTorque = torque;
        backRight.brakeTorque = torque;
    }

    void setAllMotorTorques(float torque)
    {
        frontLeft.motorTorque = torque;
        frontRight.motorTorque = torque;
        backLeft.motorTorque = torque;
        backRight.motorTorque = torque;
    }
}
