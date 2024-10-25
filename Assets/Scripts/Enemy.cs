using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{

    public int Health;
    public TextMeshProUGUI enemyHealthUI;


    private void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        //some code
        enemyHealthUI.text = Health.ToString();
        // more code
    }
  
    public void TimeOut()
    {
        Death();
    }

    public void ChangeHealth(int damage)
    {
        Health += damage;
                
        UpdateUI();

        if (Health <= 0)
        {
            Death();
        }

    }

    private void Death()
    {
        //Enemy Death
        // Use Animation
        //Show VFX
        //Play SFX
        Destroy(gameObject);
    }
}
