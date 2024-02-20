using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
    public List<WheelJoint2D> colliders;

    public float RotationSpeed;
    void Start()
    {
        colliders= GetComponents<WheelJoint2D>().ToList();
    }

    public void UpPower()
    {
        foreach (WheelJoint2D wheel in colliders)
        {
            JointMotor2D motor = wheel.motor;
            motor.motorSpeed += -1;
            wheel.motor = motor;

        }
    }
    public void StartEngine()
    {
        foreach (WheelJoint2D wheel in colliders)
        {
            JointMotor2D motor = wheel.motor;
            motor.motorSpeed = -RotationSpeed;
            wheel.motor = motor;
        
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
