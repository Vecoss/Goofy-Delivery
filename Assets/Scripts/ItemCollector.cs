using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// This code is no longer used, it's how the previous package code looked

public class ItemCollector : MonoBehaviour
{
    public GameEvent packageEvent;
    public intAmount packageAmount;
    public int actionCounter = 0;
    public Collider collision;



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {

            collision.gameObject.SetActive(false);

            if ((actionCounter % 2) == 0)
            {
                packageAmount.amount++;
                
            }

            
                        actionCounter++;
        }
    }


}
