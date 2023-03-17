using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullets : MonoBehaviour
{

    public int bullets;
    public bool isFiring;
    public Text bulletsDisplay;

    void Start()
    {
       
    }
    void Update()
    {
        bulletsDisplay.text = "Bullets: " + bullets.ToString();
        if(Input.GetMouseButtonDown(0) && !isFiring && bullets > 0)
        {
            isFiring = true;
            bullets--;
            isFiring = false;
        }
    }
}