/*
 * Script for creating IK constraints such as attaching hands to a gun
 * Main Editor: Josh-Tim Allen
 */

using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Animator))]

public class IKController : MonoBehaviour {

    protected Animator animator;

    public bool ikActive = false;
    [SerializeField] Transform rightHandTarget = null;
    [SerializeField] Transform leftHandTarget = null;
    
    [SerializeField] Transform rightHandHint = null;
    [SerializeField] Transform leftHandHint = null;
    [SerializeField] Transform lookObj = null;
    [Range(0,1)]
    public float rightHandWeight = 0;
    [Range(0,1)]
    public float leftHandWeight = 0;
    [Range(0,1)]
    public float rightHandHintWeight = 0;
    [Range(0,1)]
    public float leftHandHintWeight = 0;
    void Start() {
        animator = GetComponent<Animator>();
    }

    //a callback for calculating IK
    void OnAnimatorIK() {
        if (animator) {

            //if the IK is active, set the position and rotation directly to the goal. 
            if (ikActive) {

                // Set the look target position, if one has been assigned
                if (lookObj != null) {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(lookObj.position);
                }

                // Set the right hand target position and rotation, if one has been assigned
                if (rightHandTarget != null) {
                    animator.SetIKPositionWeight(AvatarIKGoal.RightHand, rightHandWeight);
                    animator.SetIKRotationWeight(AvatarIKGoal.RightHand, rightHandWeight);
                    animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTarget.position);
                    animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTarget.rotation);

                    if (rightHandHint != null) {
                        animator.SetIKHintPosition(AvatarIKHint.RightElbow, rightHandHint.position);
                        animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, rightHandHintWeight);
                    }
                    else {
                        animator.SetIKHintPositionWeight(AvatarIKHint.RightElbow, 0);
                    }
                }
                if (leftHandTarget != null) {
                    animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, leftHandWeight);
                    animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, leftHandWeight);
                    animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandTarget.position);
                    animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandTarget.rotation);

                    if (leftHandHint != null) {
                        animator.SetIKHintPosition(AvatarIKHint.LeftElbow, leftHandHint.position);
                        animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, leftHandHintWeight);
                    }
                    else {
                        animator.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, 0);
                    }
                }

            }

            //if the IK is not active, set the position and rotation of the hand and head back to the original position
            else {
                animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 0);
                animator.SetLookAtWeight(0);
            }
        }
    }
}
