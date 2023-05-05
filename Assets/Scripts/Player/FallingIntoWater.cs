using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingIntoWater : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y < -5)
        {
            Destroy(gameObject);

            //Dodaj tutaj przechodzenie na ekran wyniku przegranej
        }
    }
}
