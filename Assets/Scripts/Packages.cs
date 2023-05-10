using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packages : MonoBehaviour
{

    public GameObject[] houses;
    public GameObject PackageSpawn;
    // Start is called before the first frame update
    void Start()
    {
Instantiate(PackageSpawn);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
