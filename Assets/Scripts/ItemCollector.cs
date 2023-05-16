using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int packages = 0;

    [SerializeField] private TextMeshProUGUI packagesText;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Package"))
        {
            Destroy(collision.gameObject);
            packages++;
            packagesText.text = "Packages: " + packages;
        }
    }
}
