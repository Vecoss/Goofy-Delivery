using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Delivery : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] packagePool;
    public GameObject currentPackage;
    private int packages = 0;
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
            collision.gameObject.SetActive(false);
            packages++;
            packageCheck = 1;

        }
        if (packages % 2 == 0)
        {
            packagesText.text = "Packages: " + packages/2;
        }

        if (packageCheck == 1)
        {
            packageCheck = 0;
            do
            {
                index = Random.Range(0, packagePool.Length);
                currentPackage = packagePool[index];
           
                currentPackage.SetActive(true);

                if (currentPackage.gameObject == collision.gameObject)
                    currentPackage = null;
            }
            while (currentPackage == false);
            print(currentPackage.name);

        }
    }
}
