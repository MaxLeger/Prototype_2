using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{

    public int speed;

    GameObject speedUI;

    FirstPersonController scriptu;

    
    void Start()
    {
        speedUI = GameObject.Find("Speed");
        scriptu = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
    }
    void Update()
    {
        speedUI.GetComponent<Text>().text = speed.ToString();
         
        speed = (int)scriptu.sprintSpeed;
       
        
    }
}