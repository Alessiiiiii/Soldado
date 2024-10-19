using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMove : MonoBehaviour
{
    public float PlayerSpeed = 2.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 moveRelative = transform.TransformDirection(move) * PlayerSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + moveRelative);

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.None;
        }
    }
}
