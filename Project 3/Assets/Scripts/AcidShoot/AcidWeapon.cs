using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidWeapon : MonoBehaviour
{
    private int i = 0;
    void Update()
    {
        if (i == 40){
            Shoot();
            i = 0;
        }
        else
            i++;
    }

    public Transform firePoint;
    public GameObject bullet;

    private void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
