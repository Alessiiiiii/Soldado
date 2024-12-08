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
   public GameController gameController;
    public GameObject DeathEffect;


    private void Start()
    {
        UpdateUI();
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
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
        Health -= damage;
                
        UpdateUI();

        if (Health <= 0)
        {
            Death();
        }

    }

    private void Death()
    {
        if (DeathEffect != null) { Instantiate(DeathEffect, transform.position, Quaternion.identity); }
        //Enemy Death
        // Use Animation
        //Show VFX
        //Play SFX
        gameController.AddKill();
        Destroy(gameObject);
    }
}
