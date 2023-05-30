using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Delivery : ItemCollector
{
    // Start is called before the first frame update
    static float checker = 0;
    public TMP_Text pickupdeliverthepackage;
  // public TMP_Text Meters;
    public GameObject[] packagePool;
   // private Renderer PackageMeshRender;
    public GameObject[] destinationPool;
    public GameObject currentPackage;
    public Transform currentCarDistance;
    public Transform positionTool;
  //  private int packages = 0;
    public float packageCheck = 0;
    public float meshCheck = 0;
    int index;
    [SerializeField] private TextMeshProUGUI packagesText;
    // Pod��cz to do wszystkich aut i zr�b du�o package'y


    void Start()  
    {
         //   new MeshRenderer[packagePool.Length] = PackageMeshRender;
        

        packagePool = GameObject.FindGameObjectsWithTag("Package");
        index = Random.Range(0, packagePool.Length);
        currentPackage = packagePool[index];
        print(currentPackage.name);
        for (int i = 0; i < packagePool.Length; i++)
        {
         //   PackageMeshRender[i] = packagePool[i].GetComponent<Renderer>();
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

            checker++;

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
        //    if (meshCheck==0);
        //    {EnableRenderer(PackageMeshRender, false);
        //    meshCheck=1;
         //   }
        //    if (meshCheck==1)
        //    {
        //    EnableRenderer(PackageMeshRender, true);
        //    meshCheck=0;
        //    }
            print(currentPackage.name);
            packageCheck = 0;
            if (checker%2==1)
            {pickupdeliverthepackage.text = "Deliver the Package";
            Debug.Log("jeden");
            }
            else if (checker%2==0)
            {pickupdeliverthepackage.text = "Pick up the Package";
            Debug.Log("dwa");
            }

        }
    }
       void Update()
    {
        float distance = Vector3.Distance(currentCarDistance.position, currentPackage.transform.position);
      distance.ToString();
        Debug.Log(distance + " m away");
 //       Meters.text = (distance + " m away");
    }

}
