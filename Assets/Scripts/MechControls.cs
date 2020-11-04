/*
 * Script for controlling the mechas that attack the shuttle
 * Main Editor: Josh-Tim Allen
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

[RequireComponent(typeof(Rigidbody))]
public class MechControls : MonoBehaviour {
    [SerializeField] new Rigidbody rigidbody = null;
    [SerializeField] float Speed = 8;
    [SerializeField] float MaxSpeed = 10;
    [SerializeField] float Acceleration = 3;
    Transform cameraTransform;
    PlayerInputActions input;
    Vector3 targetVelocity;
    Vector2 inputVector;

    MechaAnimate animate;
    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        animate = GetComponent<MechaAnimate>();
        cameraTransform = Camera.main.transform;
        input = new PlayerInputActions();
        input.Enable();
        input.Player.Movement.performed += Move;
    }
    private void Move(CallbackContext context) {
        inputVector = context.ReadValue<Vector2>();
        if(inputVector != Vector2.zero) {
            animate.Fly(true);
        }
        else {
            animate.Fly(false);
        }
    }
    void Update() {
        transform.rotation =  cameraTransform.rotation;        
    }
    Vector3 direction;
    private void FixedUpdate() {
        rigidbody.angularVelocity = Vector3.zero;
        direction = ((transform.forward * inputVector.y) + (transform.right * inputVector.x));
        targetVelocity = direction * Speed;
        rigidbody.velocity = targetVelocity;// Vector3.Lerp(rigidbody.velocity, targetVelocity, Acceleration * Time.fixedDeltaTime);
    }
    private void OnEnable() {
        if (input != null) {
            input.Enable();
        }
    }
    private void OnDisable() {
        input.Disable();
    }
}