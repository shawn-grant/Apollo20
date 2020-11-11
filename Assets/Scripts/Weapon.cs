using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
    public WeaponType equipType;
    [SerializeField] internal Transform shootPosition = null;
    public Transform leftHandGrip;
    public Transform rightHandGrip;
    public virtual void Fire(Vector3 direction) {

    }
}
public enum WeaponType {
    OneHandedGun,
    TwoHandedGun,
}