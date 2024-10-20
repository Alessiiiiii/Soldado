using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public float bulletForce;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject bulletClone =Instantiate(objectPrefab,transform.position,transform.rotation);
            Rigidbody bulletRigidBody = bulletClone.GetComponent<Rigidbody>();
            bulletRigidBody.velocity = transform.forward * bulletForce;
            Destroy(bulletClone, 2f);
        }
    }
}
