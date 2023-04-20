using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.layer == 3) 
        {
            Debug.Log("1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("2");
    }
}
