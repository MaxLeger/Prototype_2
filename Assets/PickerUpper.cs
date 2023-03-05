using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerUpper : MonoBehaviour
{
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("PickUp1"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 1;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("PickUp Count" + count);
        }
        else if (collision.collider.gameObject.CompareTag("PickUp2"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 5;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("PickUp Count" + count);
        }
        else if (collision.collider.gameObject.CompareTag("PickUp3"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 10;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("PickUp Count" + count);
        }
        else if (collision.collider.gameObject.CompareTag("PickUp4"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 25;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("PickUp Count" + count);
        }
        else if (collision.collider.gameObject.CompareTag("PickUp5"))
        {
            GameObject.Destroy(collision.collider.gameObject);

            count = count + 100;

            this.GetComponent<AudioSource>().Play();

            Debug.Log("PickUp Count" + count);
        }
    }
}
