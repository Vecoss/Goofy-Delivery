using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public GameEvent packageEvent;
    public intAmount packageAmount;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
            packageAmount.amount++;
            packageEvent.Fire();
            Destroy(collision.gameObject);
        }
    }
}
