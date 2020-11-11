using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Equipment : MonoBehaviour {
    /// <summary>
    /// Stores the weapon currently in use. An Array is used for two handed weapons
    /// </summary>
    Weapon[] equipedWeapons = new Weapon[2];
    /// <summary>
    /// List of all weapons Owned
    /// </summary>
    List<Weapon> Weapons = new List<Weapon>();
    void Start() {

    }
    void Update() {
        Keyboard keyboard = InputSystem.GetDevice<Keyboard>();
        if (keyboard.anyKey.wasPressedThisFrame) {
            var keysPressed = keyboard.allKeys.ToList().FindAll(k => k.wasPressedThisFrame);
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(0);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(1);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(2);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(3);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(4);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(5);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(6);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(7);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(8);
            }
            if (keyboard.digit0Key.wasPressedThisFrame) {
                EquipItem(9);
            }
        }
    }
    void EquipItem(int index) {

    }
}