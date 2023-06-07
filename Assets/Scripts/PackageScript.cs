using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

// Made some comments to help you easily navigate through code ~ Kuba

public class TestingGE : MonoBehaviour, IGameEventListener
{
    [SerializeField] 
    private GameEvent gameEventToListen;
    static float checker = 0;
    public TextMeshProUGUI pickupdeliverthepackage;
    public GameObject[] packagePool;
    public GameObject[] destinationPool;
    public GameObject[] GPSPool;
    public GameObject currentPackage;
    public GameObject currentGPS;
    public float packageCheck = 0;
    public float meshCheck = 0;
    int index;
    int index2;
    [SerializeField] private TextMeshProUGUI packagesText;


    public int xd = 0;

void Start()  
    {
        // Here we desactivate all components of a Package -> a Package object, a Destination object and a GPS object.
        // We also roll a random index. A package and a GPS with that index in the array will be set active for the player to find.

        index = Random.Range(0, packagePool.Length);
        index2 = index;
        currentPackage = packagePool[index];
        print(currentPackage.name);
        for (int i = 0; i < packagePool.Length; i++) 
        {
            packagePool[i].SetActive(false);
        }

        for (int i = 0; i < destinationPool.Length; i++) 
        {
            destinationPool[i].SetActive(false);
        }
        for (int i = 0; i < GPSPool.Length; i++) 
        {
            GPSPool[i].SetActive(false);
        }

        currentGPS = GPSPool[index];
        currentPackage.SetActive(true);
        currentGPS.SetActive(true);
    }

    // IGameEventListener's OnEnable and OnDisable. Nothing crazy.
public void OnEnable()
    {
        if (gameEventToListen != null) gameEventToListen.RegisterListener(this);
    }

public void OnDisable()
    {
        gameEventToListen.UnregisterListener(this);
    }

    // Notify triggers when anyPackage Event is triggered, so when you collide with either a Package or a Destination.
    // Every odd 'checker' value makes your target a Package to pick up. Every even 'checker' value makes it a Destination to deliver the package.
public void Notify()
    {
        xd = 3;
        checker++;
            
            
            if (checker%2==1)
            {
                
                do
            {
                index = Random.Range(0, destinationPool.Length);
                currentPackage = destinationPool[index];
           
                if (index != index2)
                   {packageCheck = 1;}
            }
            while (packageCheck==0);
            currentPackage.SetActive(true);
            currentGPS.SetActive(false);
            currentGPS = GPSPool[index];
            currentGPS.SetActive(true);
            index2 = index;
            print(currentPackage.name);
            packageCheck = 0; 
            }


            else if (checker%2==0)
            {
                
                do
            {
            
                index = Random.Range(0, packagePool.Length);
                currentPackage = packagePool[index];
           
                if (index != index2)
                   {packageCheck = 1;}
            }
            while (packageCheck==0);
            currentPackage.SetActive(true);
            currentGPS.SetActive(false);
            currentGPS = GPSPool[index];
            currentGPS.SetActive(true);
            index2 = index;
            print(currentPackage.name);
            packageCheck = 0;  
            }


    }

}
