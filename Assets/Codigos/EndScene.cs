using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
    
{
    public float waitTime = 5f;
    void Start()
    {
        Invoke("LoadMenu",waitTime);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
