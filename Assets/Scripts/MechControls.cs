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
    [SerializeField] Transform AXIS = null;
    [SerializeField] float Speed = 8;
    [SerializeField] float MaxSpeed = 10;
    [SerializeField] float Acceleration = 3;
    [SerializeField] float RotationSpeed = 3;
    [SerializeField] Gun gun = null;
    Transform cameraTransform;
    PlayerInputActions input;
    Vector3 targetVelocity;
    Vector2 inputVector;
    public Vector2 mouseMove;
    MechaAnimate animate;
    float X_rot;
    float Y_rot;
    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        animate = GetComponent<MechaAnimate>();
        cameraTransform = Camera.main.transform;
        input = new PlayerInputActions();
        input.Enable();
        input.Player.Movement.performed += Move;
        input.Player.Swipe.performed += OnMouseMove;
    }
    void Shoot() {
        gun.Fire(Camera.main.transform.forward);
    }
    private void OnMouseMove(CallbackContext context) {
        mouseMove = context.ReadValue<Vector2>();
        //print(context.ReadValue<float>());
        X_rot -= mouseMove.y;
        Y_rot += mouseMove.x;
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
    [SerializeField] Transform up = null;
    [SerializeField] Transform right = null;
    [SerializeField] Matrix4x4 matrix4X4 = new Matrix4x4();
    void Update() {
        Quaternion xRot_T = Quaternion.AngleAxis(Y_rot, transform.up);
        Quaternion yRot_T = Quaternion.AngleAxis(X_rot, transform.right);
        Y_rot = 0;
        X_rot = 0;
        //transform.RotateAround()
        transform.RotateAround(transform.position,transform.up, mouseMove.x * RotationSpeed * Time.deltaTime); //Quaternion.Lerp(transform.rotation, xRot_T * yRot_T, RotationSpeed * Time.deltaTime);
        transform.RotateAround(transform.position,transform.right, -mouseMove.y * RotationSpeed * Time.deltaTime); //Quaternion.Lerp(transform.rotation, xRot_T * yRot_T, RotationSpeed * Time.deltaTime);

        //transform.rotation = Quaternion.Lerp(transform.rotation, xRot_T, RotationSpeed* Time.deltaTime);
        //AXIS.localEulerAngles = new Vector3(X_rot, 0, 0);
        //AXIS.localRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(X_rot,0,0), RotationSpeed* Time.deltaTime);
        //transform.rotation = Quaternion.AngleAxis(Y_rot, Vector3.up);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, up.transform.rotation, 10 * Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, right.transform.rotation, 10 * Time.deltaTime);
        //transform.Rotate(10, 10f, 0);

        /* float X = up.transform.eulerAngles.x;
         float Y = up.transform.eulerAngles.y;
         float Z = up.transform.eulerAngles.z;
         Quaternion newRot = new Quaternion();
         newRot.x = (sin(Y) * sin(Z) * cos(X)) + cos(Y) * cos(Z) * sin(X);
         newRot.y = (sin(Y) * cos(Z) * cos(X)) + (cos(Y) * sin(Z) * sin(X));
         newRot.z = (cos(Y) * sin(Z) * cos(X)) - (sin(Y) * cos(Z) * sin(X));
         newRot.w = (cos(Y) * cos(Z) * cos(X)) - (sin(Y) * sin(Z) * sin(X));
         transform.rotation = newRot;*/

        Mouse mouse = Mouse.current;
        if (mouse.leftButton.isPressed) {
            Shoot();
        }
    }
    float sin(float val) {
        return Mathf.Sin(val);
    }
    float cos(float val) {
        return Mathf.Cos(val);
    }
    Vector3 direction;
    private void FixedUpdate() {
        rigidbody.angularVelocity = Vector3.zero;
        direction = ((transform.forward * inputVector.y) + (transform.right * inputVector.x));
        targetVelocity = direction * Speed;
        rigidbody.velocity = targetVelocity;// Vector3.Lerp(rigidbody.velocity, targetVelocity, Acceleration * Time.fixedDeltaTime);
        //transform.rotation = Quaternion.LookRotation(transform.position + direction.normalized);
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