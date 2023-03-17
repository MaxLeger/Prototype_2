using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    Currency script;

    public int addAmount;

    [Header("Stats")]
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyEnemy();
    }

    void Start()
    {
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
    }

    public void DestroyEnemy()
    {
        script.gold += addAmount;
        Destroy(gameObject);
        
    }
}