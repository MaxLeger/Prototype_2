using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
 { 

public float rotationSpeed = 0.3f;

private bool rotate;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R))
            {
            rotate = true;
        }
        else
        {
            rotate = false;
        }
    }

    // Update is called once per interval every time
    void FixedUpdate()
{
   this.GetComponent<Transform>().Rotate(0, 0.3f, 0);


   }

}

    
 
