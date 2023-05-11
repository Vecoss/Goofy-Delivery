using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelecting : MonoBehaviour
{
    [SerializeField] public List<GameObject> cars;
    public int counter = 0;

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
        if (counter >= cars.Count-1)
        {
            counter = 0;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[counter].SetActive(true);
        }
        else
        {
            counter++;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[counter].SetActive(true);

        }
    }

    public void PreviousCar()
    {
        Debug.Log("Wstecz");
        if (counter <= 0)
        {
            counter = cars.Count-1;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[counter].SetActive(true);
        }
        else
        {
            counter--;
            foreach (GameObject obj in cars)
            {
                obj.SetActive(false);
            }
            cars[counter].SetActive(true);

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
