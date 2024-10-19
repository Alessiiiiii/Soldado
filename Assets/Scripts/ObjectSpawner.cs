using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectPrefab;

    public Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectPrefab,spawnPosition,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
