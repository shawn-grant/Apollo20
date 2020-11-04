using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechaAnimate : MonoBehaviour {
    Animator animator;
    void Start() {
        animator = GetComponentInChildren<Animator>();
    }
    public void Fly(bool active) {
        animator.SetBool("Flying", active);
    }
}