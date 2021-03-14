﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{

    [SerializeField]
    GameObject bullet;

    float fireRate;
    float nextFire;


    // Start is called before the first frame update
    void Start()
    {
        fireRate =  1f;
        nextFire = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckIfTimeForFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate; 
        }
    }
}
