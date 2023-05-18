using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelecting : MonoBehaviour
{
    [SerializeField] public List<GameObject> cars;
    public CarSelection car;

    private void Awake()
    {
        foreach (GameObject obj in cars)
        {
            obj.SetActive(false);
        }

        cars[0].SetActive(true);

    }
    public void NextCar()
    {
        Debug.Log("Do przodu");
        if (car.selectedCar >= cars.Count-1)
        {
            car.selectedCar = 0;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.selectedCar].SetActive(true);
        }
        else
        {
            car.selectedCar++;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.selectedCar].SetActive(true);

        }
    }

    public void PreviousCar()
    {
        Debug.Log("Wstecz");
        if (car.selectedCar <= 0)
        {
            car.selectedCar = cars.Count-1;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.selectedCar].SetActive(true);
        }
        else
        {
            car.selectedCar--;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[car.selectedCar].SetActive(true);

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
