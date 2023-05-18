using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCar : MonoBehaviour
{
    public GameObject[] cars;
    public CarSelection car;

    private void Awake()
    {
        Instantiate(cars[car.selectedCar], gameObject.transform.position, Quaternion.identity);
    }
}
