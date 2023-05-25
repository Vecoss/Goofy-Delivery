using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelecting : MonoBehaviour
{
    [SerializeField] public List<GameObject> cars;
    public intAmount car;

    private void Awake()
    {
        foreach (GameObject obj in cars)
        {
            obj.SetActive(false);
        }

        cars[car.amount].SetActive(true);

    }
    public void NextCar()
    {
        Debug.Log("Do przodu");
        if (car.amount >= cars.Count-1)
        {
            car.amount = 0;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.amount].SetActive(true);
        }
        else
        {
            car.amount++;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.amount].SetActive(true);

        }
    }

    public void PreviousCar()
    {
        Debug.Log("Wstecz");
        if (car.amount <= 0)
        {
            car.amount = cars.Count-1;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.amount].SetActive(true);
        }
        else
        {
            car.amount--;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.amount].SetActive(true);

        }
    }

    public void ConfirmSelection()
    {
        SceneManager.LoadScene("MainScene");   
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
