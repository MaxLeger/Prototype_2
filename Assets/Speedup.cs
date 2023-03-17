using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedup : MonoBehaviour
{

    Currency script;

    FirstPersonController scriptu;

    Projectile projectiles;

    BoxCollider _col;

    Bullets bullets;

    AddonProjectiles addon;


    public int cost;
    public int speedIncrease;
    public int totalThrows;
    public int throwCooldown;
    public int throwForce;
    public int damage;


    void Start()
    {
        
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        bullets = GameObject.FindWithTag("GameController").GetComponent<Bullets>();
        scriptu = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
        projectiles = GameObject.FindWithTag("Player").GetComponent<Projectile>();
        _col = gameObject.GetComponent<BoxCollider>();
        addon = GameObject.FindWithTag("Projectile").GetComponent<AddonProjectiles>();

    }
    void OnTriggerEnter()
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;

            bullets.bullets += totalThrows;

            scriptu.sprintSpeed += speedIncrease;

            projectiles.totalThrows += totalThrows;

            projectiles.throwCooldown += throwCooldown;

            projectiles.throwForce += throwForce;

            addon.damage += damage;


            _col.enabled = false;
        }
    }

   
}