/*
 * Script for gun to shoot . 
 * Main Editor: Josh-Tim Allen
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon {
    [SerializeField] float bulletSpeed = 60;    
    float lastfireTime = -100;
    [SerializeField] float fireInterval = 1;
    [SerializeField] float MaxDistance;
    void Start() {

    }
    public override void Fire(Vector3 direction) {
        if((Time.time - lastfireTime) < fireInterval){ return;}
        lastfireTime = Time.time;
        Bullet bullet = ObjectPool.Instance.GetBullet();
        bullet.transform.position = shootPosition.position;
        bullet.transform.rotation = shootPosition.rotation;
        bullet.rigidbody_.velocity = direction * bulletSpeed;
        ObjectPool.Instance.DestroyBullet(bullet, MaxDistance / bulletSpeed);
    }
    void Update() {

    }
}