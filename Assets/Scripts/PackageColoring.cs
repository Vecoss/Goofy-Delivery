using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageColoring : MonoBehaviour
{
    Renderer rend;
    public Material[] material;
    public bool deliveryCheck = true;
    // Start is called before the first frame update
    void Start()
    {
        rend.GetComponent<Renderer>();
        rend.enabled=true;
        rend.sharedMaterial = material[0];
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package") && deliveryCheck == true)
        {
            rend.sharedMaterial = material[1];
        }else
        {
            rend.sharedMaterial = material[0];
        }

        deliveryCheck = !deliveryCheck;
    }
}
