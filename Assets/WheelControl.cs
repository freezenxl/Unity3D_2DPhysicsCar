using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl : MonoBehaviour
{
    [SerializeField]private  WheelJoint2D rear;
    [SerializeField]private WheelJoint2D front;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            front.useMotor = true; 
            
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            front.useMotor = false; 
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rear.useMotor = true; 
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rear.useMotor = false;
        }
    }
}
