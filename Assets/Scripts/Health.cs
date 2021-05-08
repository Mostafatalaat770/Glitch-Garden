using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int healthPoints = 200;
    [SerializeField] GameObject deathVFX;
    
    public int getHealthPoints()
    {
        return healthPoints;
    }

    public void Hit(int damage)
    {
        healthPoints -= damage;
        if(healthPoints <= 0)
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        Destroy(Instantiate(deathVFX, transform.position, transform.rotation),1f);
        Destroy(gameObject);
        
    }
}
