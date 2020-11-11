/*
 * Script for pooling objects such as bullets to reuse
 * Main Editor: Josh-Tim Allen
 */

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {
    public static ObjectPool Instance { get; private set; }
    [SerializeField] int starterAmount;
    [SerializeField] Bullet bulletPrefab = null;
    Queue<Bullet> bulletPool = new Queue<Bullet>();
    static Dictionary<PooledObject, Queue<object>> objectPool = new Dictionary<PooledObject, Queue<object>>();
    //static void Get
    void Awake() {
        Instance = this;
    }
    void Start() {
        for (int c = 0; c < starterAmount; c++) {
            Bullet b = Instantiate(bulletPrefab, transform);
            b.gameObject.SetActive(false);
            bulletPool.Enqueue(b);
        }
        /*
        var values = Enum.GetValues(typeof(PooledObject));
        objectPool.Add(PooledObject.bullet, new Queue<object>());
        objectPool[PooledObject.bullet].Enqueue(new GameObject());
        foreach(PooledObject po in values) {

        }*/
    }
       public Bullet GetBullet() {
        if (bulletPool.Count == 0) {
            for (int c = 0; c < 100; c++) {
                Bullet b = Instantiate(bulletPrefab, transform);
                b.gameObject.SetActive(false);
                bulletPool.Enqueue(b);
            }
        }
        Bullet bul = bulletPool.Dequeue();
        bul.gameObject.SetActive(true);
        return bul;
    }
    public void DestroyBullet(Bullet bullet, float time) {
        FUNCS.Invoke(() => { bullet.gameObject.SetActive(false); bulletPool.Enqueue(bullet); }, time, this, false);
    }
}
public enum PooledObject {
    bullet,
}