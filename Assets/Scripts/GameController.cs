using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.CompilerServices;

public class GameController : MonoBehaviour
{
    private int Kills;
    private int totalEnemy;

    [SerializeField] private TextMeshProUGUI KillsText;
    [SerializeField] private TextMeshProUGUI winText;
    // Start is called before the first frame update
    void Start()
    {
        winText.enabled = false;

        totalEnemy = GameObject.FindGameObjectsWithTag("Enemy").Length;
        UpdateUI();

    }


    public void AddKill()
    {
        Kills++;
        UpdateUI();

        if (Kills >= totalEnemy)
        {
            Win();

        }
    }
    private void UpdateUI()

    {
        KillsText.text = Kills.ToString() + " / " + totalEnemy.ToString();
    }

    private void Win()

    {
        winText.enabled = true;
    }

         
    }

