using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationController : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
           
            { 
            _animator.SetBool("Move",true);
        }

        if (Input.GetKeyDown(KeyCode.R))

        {
            _animator.SetBool("Move", false);
        }
    }
}
