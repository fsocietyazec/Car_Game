﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class araba : MonoBehaviour
{
    public WheelCollider önsoltekerlek, önsagtekerlek, arkasoltekerlek, arkasağtekerlek;

    public float motorhızı,dönmehızı;
    public Joystick tus;
   
    void Update()
    {
        arkasağtekerlek.motorTorque = motorhızı * tus.Vertical;
        arkasoltekerlek.motorTorque = motorhızı * tus.Vertical;
        önsagtekerlek.steerAngle = dönmehızı * tus.Horizontal;
        önsoltekerlek.steerAngle = dönmehızı * tus.Horizontal;
    }
}