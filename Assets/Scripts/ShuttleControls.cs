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
    public float launchSpeed = 10,
        flySpeed = 50,
        turnSpeed = 5;
    [HideInInspector]
    public bool inGame = false;
    [HideInInspector]
    public bool launching = false;

    private void Awake()
    {
        inputActions = new ShuttleInputActions();
        
        //inputActions.Flight.Pitch.started += ctx => braking = true;
        //inputActions.Flight.Brake.canceled += ctx => braking = false;
    }
    private void OnEnable()
    {
        inputActions.Enable();
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
        float pitch = turnSpeed * inputActions.Flight.Pitch.ReadValue<float>();
        float roll = turnSpeed * inputActions.Flight.Roll.ReadValue<float>();
        float yaw = turnSpeed * inputActions.Flight.Yaw.ReadValue<float>();

        if (inGame)
        {
            transform.Rotate(pitch * Time.deltaTime, yaw * Time.deltaTime, -roll * Time.deltaTime);
            transform.Translate(0, 0, flySpeed * Time.deltaTime);
        }

        if (launching)
        {
            transform.Translate(0, 0, launchSpeed * Time.deltaTime);
        }
        
    }
}
