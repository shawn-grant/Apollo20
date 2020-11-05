/*
 * Script for controlling the the shuttle that goes to the moon
 * Main Editor: Shawn Grant
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ShuttleControls : MonoBehaviour
{
    ShuttleInputActions inputActions;
    public float moveSpeed = 10, turnSpeed = 5;

    private void Awake()
    {
        inputActions = new ShuttleInputActions();
      
        //inputActions.Flight.Pitch.started += ctx => braking = true;
        //inputActions.Flight.Brake.canceled += ctx => braking = false;
    }
    private void OnDisable()
    {
        inputActions.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //steer values
        float pitch = moveSpeed * inputActions.Flight.Pitch.ReadValue<float>();
        float roll = turnSpeed * inputActions.Flight.Roll.ReadValue<float>();
        float yaw = turnSpeed * inputActions.Flight.Yaw.ReadValue<float>();

        transform.Rotate(pitch, yaw, roll);

    }
}
