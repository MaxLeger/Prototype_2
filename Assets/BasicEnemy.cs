using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    Currency script;

    public int addAmount;

    public HealthBar healthBar;

    [Header("Stats")]
    public int maxHealth;
    public int currentHealth;


    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


        if (currentHealth <= 0)
            DestroyEnemy();
    }

    void Start()
    {
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        

    }

    public void DestroyEnemy()
    {
        script.gold += addAmount;
        Destroy(gameObject);
        
    }
}