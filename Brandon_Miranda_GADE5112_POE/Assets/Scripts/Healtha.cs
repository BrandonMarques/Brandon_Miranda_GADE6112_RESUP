using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healtha : MonoBehaviour
{
    // Start is called before the first frame update
    

    [SerializeField]
    private int maxHealth = 100;

    private int currentHealth;
    int i;

    public event Action<float> OnHealthpctChanged = delegate { };

    private void OnEnable()
    {
        currentHealth = maxHealth;
    }

    public void ModifyHealth(int amount)
    {
        currentHealth += amount;
        float currentHealthPct = (float)currentHealth / (float)maxHealth;
        OnHealthpctChanged(currentHealthPct);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ModifyHealth(-10);

    }
}


