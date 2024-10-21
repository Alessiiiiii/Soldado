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
        enemyHealthUI.text = Health.ToString();
    }

    
    public void ChangeHealth(int damage)
    {
        Health += damage;

        UpdateUI();

        if (Health <= 0)
        {
            Destroy(gameObject);
        }

    }
}
