using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefap;
    [SerializeField] private float bulletForce;
    [SerializeField] private Transform bulletSpawn;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            
            Fire();
        }
    }
    private void Fire()
    {
        GameObject bulletClone=Instantiate(bulletPrefap,bulletSpawn.position,bulletSpawn.rotation);

        Rigidbody bulletRigibody = bulletClone.GetComponent<Rigidbody>();
        
        bulletRigibody.velocity = bulletSpawn.forward * bulletForce;

        Destroy(bulletClone, 2f);


    }
}
