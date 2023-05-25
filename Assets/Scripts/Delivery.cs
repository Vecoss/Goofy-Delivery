using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Delivery : ItemCollector
{
    // Start is called before the first frame update

    public GameObject[] packagePool;
    public GameObject[] destinationPool;
    public GameObject currentPackage;
  //  private int packages = 0;
    public float packageCheck = 0;
    int index;
    [SerializeField] private TextMeshProUGUI packagesText;
    // Pod��cz to do wszystkich aut i zr�b du�o package'y


    void Start()  
    {

        packagePool = GameObject.FindGameObjectsWithTag("Package");
        index = Random.Range(0, packagePool.Length);
        currentPackage = packagePool[index];
        print(currentPackage.name);
        for (int i = 0; i < packagePool.Length; i++)
        {
            packagePool[i].SetActive(false);
        }
        currentPackage.SetActive(true);

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
          //  collision.gameObject.SetActive(false);
        //    packages++;
        //    packageCheck = 1;

       // }
      //  if (packages % 2 == 0)
      //  {
          //  packagesText.text = "Packages: " + (packages/2);
       // }//

        //if (packageCheck == 1)
       // {
            //packageCheck = 0;
            do
            {
            
                index = Random.Range(0, packagePool.Length);
                currentPackage = packagePool[index];
           
                if (currentPackage.gameObject != collision.gameObject)
                   {packageCheck = 1;}
                   //else {packageCheck = 1;}
            }
            while (packageCheck==0);
            currentPackage.SetActive(true);
            print(currentPackage.name);
            packageCheck = 0;

        }
    }
}
