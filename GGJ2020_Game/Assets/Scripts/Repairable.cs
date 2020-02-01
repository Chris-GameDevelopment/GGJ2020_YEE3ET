﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repairable : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Number of seconds it will take to repair this object.")]
    private float damage = 5;

    private float currentDamage;

    // Start is called before the first frame update
    void Start()
    {
        currentDamage = damage;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void repairDamage(float amount)
    {
        if (currentDamage > 0)
        {
            currentDamage -= amount;

            if (currentDamage <= 0)
            {
                currentDamage = 0;

                GameController.instance.repairFinished();
            }
        }
    }

    public float getInitialDamage()
    {
        return damage;
    }

    public float getCurrentDamage()
    {
        return currentDamage;
    }
}