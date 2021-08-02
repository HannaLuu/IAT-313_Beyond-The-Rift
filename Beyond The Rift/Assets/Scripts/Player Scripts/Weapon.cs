using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    public Transform firePoint;

    public GameObject bulletPrefab;

    public Teleport teleportScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime && teleportScript.teleportMode == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    //shooting logic
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
