using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



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

            //packageEvent.Fire();
            collision.gameObject.SetActive(false);
           // Destroy(collision.gameObject);

            if ((actionCounter % 2) == 0)
            {
                packageAmount.amount++;
                
            }

            
                        actionCounter++;
        }
    }


}
