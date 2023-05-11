using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelectionConfirm : MonoBehaviour
{
    public CarSelecting car;


    private void Awake()
    {
        Instantiate(car.cars[car.counter], gameObject.transform.position, Quaternion.identity);
    }
}
