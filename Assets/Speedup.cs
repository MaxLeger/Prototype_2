using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedup : MonoBehaviour
{

    Currency script;

    FirstPersonController scriptu;

    BoxCollider _col;


    public int cost;
    public int speedIncrease;


    void Start()
    {
        
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        scriptu = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
        _col = gameObject.GetComponent<BoxCollider>();

    }
    void OnTriggerEnter()
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;

            scriptu.sprintSpeed += speedIncrease;

            _col.enabled = false;
        }
    }

   
}