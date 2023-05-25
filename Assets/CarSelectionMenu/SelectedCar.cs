using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCar : MonoBehaviour
{
    public GameObject[] cars;
    public intAmount car;
    public intAmount package;

    private void Awake()
    {
        Instantiate(cars[car.amount], gameObject.transform.position, Quaternion.Euler(0, 90, 0));
        package.amount = 0;
    }
}
