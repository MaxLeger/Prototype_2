using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Access : MonoBehaviour
{

    Currency script;

    FirstPersonController scriptu;

    BoxCollider _col;

    MeshRenderer _mesh;

    MeshCollider _box;


    public int cost;
    


    void Start()
    {

        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
        scriptu = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
        _col = gameObject.GetComponent<BoxCollider>();
        _mesh = gameObject.GetComponent<MeshRenderer>();
        _box = gameObject.GetComponent<MeshCollider>();

    }
    void OnTriggerEnter()
    {
        if (script.gold >= cost)
        {
            script.gold -= cost;

            _col.enabled = false;

            _mesh.enabled = false;

            _box.enabled = false;
        }
    }


}