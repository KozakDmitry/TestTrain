using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
    private List<WheelJoint2D> colliders;
    private bool isEngineStarted = false;
    public float RotationSpeed;
    
    void Start()
    {
        colliders = GetComponents<WheelJoint2D>().ToList();
    }


    public void UpPower()
    {
       
        foreach (WheelJoint2D wheel in colliders)
        {
            JointMotor2D motor = wheel.motor;
            motor.motorSpeed += -3;
            wheel.motor = motor;

        }
    }
    public void StartEngine()
    {
        if(!isEngineStarted)
        {
            isEngineStarted = true;
            foreach (WheelJoint2D wheel in colliders)
            {
                JointMotor2D motor = wheel.motor;
                motor.motorSpeed += -RotationSpeed;
                wheel.motor = motor;

            }
            
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreasePower()
    {
        foreach (WheelJoint2D wheel in colliders)
        {
            JointMotor2D motor = wheel.motor;
            if(motor.motorSpeed < 0) 
            {
                motor.motorSpeed += 1f;
            }
            else
            {
                motor.motorSpeed = 0;
            }
            wheel.motor = motor;

        }
        
    }
}
